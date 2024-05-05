﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.CasePage
{
    public partial class CreateCasePage : Form
    {
        public CreateCasePage()
        {
            InitializeComponent();

            btnAddClient.Click += BtnAddClient_Click;
        }

        private void BtnAddClient_Click(object? sender, EventArgs e)
        {
            new AddClientView().ShowDialog();
        }
    }
}
