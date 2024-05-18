using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Toolbox
{
    public partial class FilterSpeciality : UserControl
    {
        public string BtnText { get; set; }
        public FilterSpeciality(string speciality)
        {
            InitializeComponent();
            btnFilter.Text = speciality;
            BtnText = speciality;

            btnFilter.Click += (sender, e) => OnClick(e);
        }
    }
}
