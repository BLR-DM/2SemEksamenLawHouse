using UIModels;

namespace UI.Toolbox
{
    public partial class ClientInformation : UserControl
    {
        ClientUI client;
        public ClientInformation(ClientUI client)
        {
            this.client = client;
            InitializeComponent();

            Load += ClientDetails_Load;
        }

        private void ClientDetails_Load(object? sender, EventArgs e)
        {
            txtName.Text = string.Join(" ", client.Firstname, client.Lastname);
            txtClientID.Text = client.PersonID.ToString();
            txtEmail.Text = client.Email;
            txtPhone.Text = client.MainPhone.ToString();
            txtAddress.Text = client.AddressLine;
            txtPostal.Text = client.PostalCode.ToString();
            txtCity.Text = client.City;
        }
    }
}
