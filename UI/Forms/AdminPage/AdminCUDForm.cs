using BusinessLogic;
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

namespace UI.Forms.AdminPage
{
    public partial class AdminCUDForm : Form
    {
        FormBL formBL;
        //
        //Create
        //
        public AdminCUDForm()
        {
            InitializeComponent();

            formBL = new FormBL();


            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            btnCreateForm.Click += BtnCreateForm_Click;
        }

        private async void BtnCreateForm_Click(object? sender, EventArgs e)
        {
            FormUI formToCreate = new FormUI()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = float.Parse(txtPrice.Text)
            };

            bool isCreated = await formBL.CreateFormAsync(formToCreate);

            if (isCreated)
            {
                MessageBox.Show("Form has been created");
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR! This form hasnt been created");
            }

        }




        //
        // Update og Delete
        //

        FormUI form;
        public AdminCUDForm(FormUI form)
        {
            InitializeComponent();
            this.form = form;
            formBL = new FormBL();

            btnCreateForm.Visible = false;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;

            this.form = form;

            txtName.Text = form.Name;
            txtDescription.Text = form.Description;
            txtPrice.Text = form.Price.ToString();
        }

        private async void BtnUpdate_Click(object? sender, EventArgs e)
        {
            FormUI formToUpdate = new FormUI()
            {
                FormID = form.FormID,
                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = float.Parse(txtPrice.Text)
            };

            bool isUpdated = await formBL.UpdateFormAsync(formToUpdate);
            if (isUpdated)
            {
                MessageBox.Show("Form has been updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR! Form hasnt been updated");
            }

        }
        private async void BtnDelete_Click(object? sender, EventArgs e)
        {
            bool isDeleted = await formBL.DeleteFormAsync(form);
            if (isDeleted)
            {
                MessageBox.Show("Form has been deleted");
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR! Form hasnt been deleted");
            }
        }
    }
}
