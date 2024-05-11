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
using UIModels;

namespace UI.Forms.SubscriptionPage
{
    public partial class SubscriptionView : Form
    {
        ClientUI client;
        SubscriptionBL subscriptionBL;
        public SubscriptionView(ClientUI client)
        {
            InitializeComponent();
            this.client = client;
            subscriptionBL = new SubscriptionBL();

            btnBuySubscriptionThreeMonth.Click += BtnBuySubscriptionThreeMonth_Click;
            btnBuySubscribtionSixMonths.Click += BtnBuySubscribtionSixMonths_ClickAsync;
            btnBuySubscription12Months.Click += BtnBuySubscription12Months_Click;

            CheckSubscriptionStatus();
        }

        private async void BtnBuySubscriptionThreeMonth_Click(object? sender, EventArgs e)
        {
            await CreateSubscription(3);
        }

        private async void BtnBuySubscription12Months_Click(object? sender, EventArgs e)
        {
            await CreateSubscription(12);
        }

        private async void BtnBuySubscribtionSixMonths_ClickAsync(object? sender, EventArgs e)
        {
            await CreateSubscription(6);
        }

        private void CheckSubscriptionStatus()
        {
            if (client.ClientSub)
            {
                MessageBox.Show("Din far");
            }
        }


        public async Task CreateSubscription(int subLength)
        {
            ClientSubscriptionUI subscription = new ClientSubscriptionUI()
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(subLength),
                ClientID = client.PersonID,
                SubscriptionID = 1,
            };
            bool subscriptionIsCreated = await subscriptionBL.CreateSubscriptionAsync(subscription);
            if (subscriptionIsCreated)
            {
                MessageBox.Show("Din far");
            }
            else
                MessageBox.Show("Din mor");
        }

    }
}
