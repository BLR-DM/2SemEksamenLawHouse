using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.AdminPage
{
    public partial class AdminPageView : Form
    {
        public AdminPageView()
        {
            InitializeComponent();

            btnCreateForm.Click += BtnCreateForm_Click;
            btnUpdateForm.Click += BtnUpdateForm_Click;
            btnDeleteForm.Click += BtnDeleteForm_Click;
            btnCreateLawyer.Click += BtnCreateLawyer_Click;
        }

        private void BtnCreateLawyer_Click(object? sender, EventArgs e)
        {
            new AdminCUDLawyer().ShowDialog();
        }

        private void BtnCreateForm_Click(object? sender, EventArgs e)
        {
            AdminCUDForm createForm = new AdminCUDForm();
            createForm.ShowDialog();
        }

        private void BtnUpdateForm_Click(object? sender, EventArgs e)
        {
            AdminFormsView afv = new AdminFormsView();
            afv.ShowDialog();
        }
        private void BtnDeleteForm_Click(object? sender, EventArgs e)
        {
            AdminFormsView afv = new AdminFormsView();
            afv.ShowDialog();
        }
    }
}
