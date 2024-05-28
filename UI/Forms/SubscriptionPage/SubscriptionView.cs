using BusinessLogic;
using BusinessLogic.HelpServices;
using EntityModels;
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
            lblHelp.Click += LblHelp_Click;

        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            OpenPDF.ShowPDF("SubscriptionHelp");
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

            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to buy subscription for 3 months?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //ellers create sub
                bool subscriptionIsCreated = await CreateSubscriptionOne(3);

                if (subscriptionIsCreated)
                {
                    await frontPageView.GetPersonAsync(client.LoginDetailsID);
                    MessageBox.Show($"Successfully subscribed for 3 months!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to buy subscription for 6 months?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //ellers create sub
                bool subscriptionIsCreated = await CreateSubscriptionOne(6);

                if (subscriptionIsCreated)
                {
                    await frontPageView.GetPersonAsync(client.LoginDetailsID);
                    MessageBox.Show($"Successfully subscribed for 6 months!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to buy subscription for 12 months?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //ellers create sub
                bool subscriptionIsCreated = await CreateSubscriptionOne(12);

                if (subscriptionIsCreated)
                {
                    await frontPageView.GetPersonAsync(client.LoginDetailsID);
                    MessageBox.Show($"Successfully subscribed for 12 months!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
