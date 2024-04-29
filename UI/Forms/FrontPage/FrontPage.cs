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

namespace UI.Forms.FrontPage
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
            btnClose.Click += BtnClose_Click;


            // Close button prop
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnClose.IconSize = 30;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
