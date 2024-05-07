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

namespace UI.Forms.Self_Service
{
    public partial class FormDetails : Form
    {
        FormUI form;
        public FormDetails(FormUI form)
        {
            InitializeComponent();
            this.form = form;

            SetDetails();
        }

        private void SetDetails()
        {
            lblTitle.Text = form.Name;
        }
    }
}
