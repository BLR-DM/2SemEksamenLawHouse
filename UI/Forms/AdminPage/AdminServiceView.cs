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

namespace UI.Forms.AdminPage
{
    public partial class AdminServiceView : Form
    {
        List<ServiceUI> serviceList;
        ServiceBL serviceBL;
        public AdminServiceView()
        {
            InitializeComponent();

            serviceBL = new ServiceBL();
            SetDgv();

            dgvServiceList.CellDoubleClick += DgvServiceList_CellDoubleClick;
        }

        private void DgvServiceList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ServiceUI selectedService = serviceList[e.RowIndex] as ServiceUI;
                AdminCUDService adminCUDService = new AdminCUDService(selectedService);
                adminCUDService.ShowDialog();
                this.Close();
            }
        }

        private async void SetDgv()
        {
            serviceList = await serviceBL.GetServicesAsync();
            dgvServiceList.DataSource = serviceList;
            dgvServiceList.Columns["ServiceID"].Visible = false;
            dgvServiceList.Columns["PriceType"].Visible = false;
            dgvServiceList.Columns["ServicePriceTypeID"].Visible = false;

            dgvServiceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }

}


 
