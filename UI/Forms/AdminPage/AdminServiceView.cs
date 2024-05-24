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

            dgvServiceList.EnableHeadersVisualStyles = false;

            dgvServiceList.RowHeadersVisible = false;

            dgvServiceList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvServiceList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            dgvServiceList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvServiceList.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }

}


 
