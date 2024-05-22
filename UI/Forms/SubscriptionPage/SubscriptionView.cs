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

        //koeb 3 month sub
        private async void BtnBuySubscriptionThreeMonth_Click(object? sender, EventArgs e)
        {

            btnBuySubscriptionThreeMonth.Enabled = false;

            //tjekker om client allerede er sub
            if (client.IsSubscribed)
            {
                MessageBox.Show("You are already subscribed!");
                btnBuySubscriptionThreeMonth.Enabled = true;
                return;
            }
            
            //ellers create sub
            bool subscriptionIsCreated = await CreateSubscriptionOne(3);
            //tester om sub er oprettet
            if (subscriptionIsCreated)
            {
                MessageBox.Show("Successfully subscribed for 3 months!");
                await frontPageView.GetPersonAsync(client.LoginDetailsID);
            }
            else
                MessageBox.Show("Failed to pay!");

            btnBuySubscriptionThreeMonth.Enabled = true;
        }

        //koeb 6 month sub
        private async void BtnBuySubscribtionSixMonths_ClickAsync(object? sender, EventArgs e)
        {
            btnBuySubscribtionSixMonths.Enabled = false;

            //tjekker om client allerede er sub
            if (client.IsSubscribed)
            {
                MessageBox.Show("You are already subscribed!");
                btnBuySubscribtionSixMonths.Enabled = true;
                return;
            }

            //ellers create sub
            bool subscriptionIsCreated = await CreateSubscriptionOne(6);

            //tester om sub er oprettet
            if (subscriptionIsCreated)
            {
                MessageBox.Show("Successfully subscribed for 6 months!");
                await frontPageView.GetPersonAsync(client.LoginDetailsID);
            }
            else
                MessageBox.Show("Failed to pay!");

            btnBuySubscribtionSixMonths.Enabled = true;
        }

        //koeb 12 month sub
        private async void BtnBuySubscription12Months_Click(object? sender, EventArgs e)
        {
            btnBuySubscription12Months.Enabled = false;

            //tjekker om client allerede er sub
            if (client.IsSubscribed)
            {
                MessageBox.Show("You are already subscribed!");
                btnBuySubscription12Months.Enabled = true;
                return;
            }

            //ellers create sub
            bool subscriptionIsCreated = await CreateSubscriptionOne(12);

            //tester om sub er oprettet
            if (subscriptionIsCreated)
            {
                MessageBox.Show("Successfully subscribed for 12 months!");
                await frontPageView.GetPersonAsync(client.LoginDetailsID);
            }
            else
                MessageBox.Show("Failed to pay!");

            btnBuySubscription12Months.Enabled = true;
        }

        //metode til at oprette sub med input på length
        public async Task<bool> CreateSubscriptionOne(int subLength)
        {
            //henter den valgte abonnement type //kun en findes nu
            SubscriptionUI subscriptionOne = await subscriptionBL.GetSubscriptionAsync(1);

            //berenger den betalte pris
            float PaidPrice = CalcPaidPrice(subscriptionOne, subLength);

            //opretter nyt koeb af sub i UI
            ClientSubscriptionUI subscription = new ClientSubscriptionUI()
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(subLength),
                PaidPrice = PaidPrice,
                ClientID = client.PersonID,
                SubscriptionID = 1,
                
            };

            //opretter koeb i db
            return await subscriptionBL.CreateSubscriptionAsync(subscription);
            
        }

        //beregner den betalte pris for sub udfra length af sub
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
