﻿using BusinessLogic;
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
    public partial class SubscriptionDetailsView : Form
    {
        ClientUI client;
        List<ClientSubscriptionUI> subscriptions;
        public SubscriptionDetailsView(ClientUI client, List<ClientSubscriptionUI> clientSubscriptionUIs)
        {
            InitializeComponent();
            this.client = client;
            this.subscriptions = clientSubscriptionUIs;

            Load += SubscriptionDetailsView_Load;
        }

        private async void SubscriptionDetailsView_Load(object? sender, EventArgs e)
        {
            SetSubscriptionsDGV();
            SetDetails();
        }

        //setter dgv for subs
        private void SetSubscriptionsDGV()
        {
            dgvSubscriptions.DataSource = subscriptions;
            dgvSubscriptions.Columns[0].Visible = false;
            dgvSubscriptions.Columns[4].Visible = false;
            dgvSubscriptions.Columns[5].Visible = false;
            dgvSubscriptions.AllowUserToResizeRows = false;
            dgvSubscriptions.AllowUserToResizeColumns = false;
            dgvSubscriptions.ReadOnly = true;
            dgvSubscriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        //setter details for clientens sub
        private void SetDetails()
        {
            if (client.IsSubscribed == false) { lblSubscribed.Text = "No"; }
            else if (client.IsSubscribed == true) { lblSubscribed.Text = "Yes"; }
            else { lblSubscribed.Text = "Undefined"; }

            //henter aktiv sub hvis exist
            ClientSubscriptionUI? activeSubscription = subscriptions.FirstOrDefault(cs => cs.EndDate >= DateTime.Now && cs.StartDate <= DateTime.Now);
            if (activeSubscription != null)
            {
                //beregner og udskriver tid tilbage på sub
                TimeSpan timeTillExpiration = activeSubscription.EndDate - DateTime.Now;
                int daysUntilExpiration = (int)timeTillExpiration.TotalDays;
                lblSubscribed.Text = lblSubscribed.Text + $" - Expires in: {daysUntilExpiration} Days\n on the {activeSubscription.EndDate.Day} of {activeSubscription.EndDate.ToString("MMMM")}";
            }
        }
    }
}
