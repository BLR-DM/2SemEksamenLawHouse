﻿using EntityModels;
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
            List<Employee> employees = new List<Employee>();

            Lawyer lawyer1 = new Lawyer() { Title = LawyerTitle.type1,  }


        }
    }
}
