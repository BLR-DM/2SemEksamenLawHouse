using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.FrontPage;
using UIModels;

namespace UI.Forms.SubscriptionPage
{
    public partial class SubscriptionView : Form
    {
        ClientUI client;
        FrontPageView frontPageView;
        SubscriptionBL subscriptionBL;
        public SubscriptionView(FrontPageView frontPageView, ClientUI client)
        {
            InitializeComponent();
            this.client = client;
            this.frontPageView = frontPageView;
            subscriptionBL = new SubscriptionBL();
            btnBuySubscriptionThreeMonth.Click += BtnBuySubscriptionThreeMonth_Click;
            btnBuySubscribtionSixMonths.Click += BtnBuySubscribtionSixMonths_ClickAsync;
            btnBuySubscription12Months.Click += BtnBuySubscription12Months_Click;

        }

        private async void BtnBuySubscriptionThreeMonth_Click(object? sender, EventArgs e)
        {

            btnBuySubscriptionThreeMonth.Enabled = false;

            if (client.IsSubscribed)
            {
                MessageBox.Show("You are already subscribed!");
                btnBuySubscriptionThreeMonth.Enabled = true;
                return;
            }

            bool subscriptionIsCreated = await CreateSubscriptionOne(3);
            if (subscriptionIsCreated)
            {
                MessageBox.Show("Successfully subscribed for 3 months!");
                await frontPageView.GetPersonAsync(client.LoginDetailsID);
            }
            else
                MessageBox.Show("Failed to pay!");

            btnBuySubscriptionThreeMonth.Enabled = true;
        }

        private async void BtnBuySubscribtionSixMonths_ClickAsync(object? sender, EventArgs e)
        {
            btnBuySubscribtionSixMonths.Enabled = false;

            if (client.IsSubscribed)
            {
                MessageBox.Show("You are already subscribed!");
                btnBuySubscribtionSixMonths.Enabled = true;
                return;
            }


            bool subscriptionIsCreated = await CreateSubscriptionOne(6);
            if (subscriptionIsCreated)
            {
                MessageBox.Show("Successfully subscribed for 6 months!");
                await frontPageView.GetPersonAsync(client.LoginDetailsID);
            }
            else
                MessageBox.Show("Failed to pay!");

            btnBuySubscribtionSixMonths.Enabled = true;
        }

        private async void BtnBuySubscription12Months_Click(object? sender, EventArgs e)
        {
            btnBuySubscription12Months.Enabled = false;

            if (client.IsSubscribed)
            {
                MessageBox.Show("You are already subscribed!");
                btnBuySubscription12Months.Enabled = true;
                return;
            }

            bool subscriptionIsCreated = await CreateSubscriptionOne(12);
            if (subscriptionIsCreated)
            {
                MessageBox.Show("Successfully subscribed for 12 months!");
                await frontPageView.GetPersonAsync(client.LoginDetailsID);
            }
            else
                MessageBox.Show("Failed to pay!");

            btnBuySubscription12Months.Enabled = true;
        }

        public async Task<bool> CreateSubscriptionOne(int subLength)
        {
            SubscriptionUI subscriptionOne = await subscriptionBL.GetSubscriptionAsync(1);

            float PaidPrice = CalcPaidPrice(subscriptionOne, subLength);

            ClientSubscriptionUI subscription = new ClientSubscriptionUI()
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(subLength),
                PaidPrice = PaidPrice,
                ClientID = client.PersonID,
                SubscriptionID = 1,
                
            };


            return await subscriptionBL.CreateSubscriptionAsync(subscription);
            
        }

        private float CalcPaidPrice(SubscriptionUI subscription, int subLength)
        {
            switch(subLength)
            {
                case 3:
                    return subscription.Price * 3;
                case 6:
                    return (subscription.Price - 5) * 6;
                case 7:
                    return (subscription.Price - 10) * 12;
                default: return 0;
            }
        }

    }
}
