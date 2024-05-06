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
    public partial class ClientDetails : Form
    {
        ClientUI client;
        public ClientDetails(ClientUI client)
        {
            InitializeComponent();
            client = this.client;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
