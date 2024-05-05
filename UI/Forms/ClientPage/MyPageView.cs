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

namespace UI.Forms.ClientPage
{
    public partial class MyPageView : Form
    {
        public MyPageView(ClientUI currentUser)
        {
            InitializeComponent();
            lblFirstname.Text = currentUser.Firstname;
            lblSub.Text = currentUser.ClientSub.ToString();

            lblMustSubscribe.Text = "        Subscribe\n To use calculations";
        }
    }
}
