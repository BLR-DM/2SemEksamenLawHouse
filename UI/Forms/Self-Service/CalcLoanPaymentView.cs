﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.Self_Service
{
    public partial class CalcLoanPaymentView : Form
    {
        public CalcLoanPaymentView()
        {
            InitializeComponent();

            btnCalculate.Click += BtnCalculate_Click;
        }

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {
            float loanSize = float.Parse(txtLoanAmmount.Text);
        }
    }
}
