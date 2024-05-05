using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI.Forms.LoginPage
{
    public partial class ForgotPasswordView : Form
    {
        public ForgotPasswordView()
        {

            InitializeComponent();

            lblCancel.MouseHover += LblCancel_MouseHover;
            lblCancel.MouseLeave += LblCancel_MouseLeave;
            lblCancel.Click += LblCancel_Click;
        }

        private void LblCancel_MouseHover(object? sender, EventArgs e)
        {
            lblCancel.Font = new Font(lblCancel.Font, FontStyle.Underline);
        }

        private void LblCancel_MouseLeave(object? sender, EventArgs e)
        {
            lblCancel.Font = new Font(lblCancel.Font, FontStyle.Regular);
        }

        private void LblCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
