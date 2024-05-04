using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.ClientPage
{
    public partial class MyPageView : Form
    {
        public MyPageView()
        {
            InitializeComponent();
            lblMustSubscribe.Text = "        Subscribe\n To use calculations";
        }
    }
}
