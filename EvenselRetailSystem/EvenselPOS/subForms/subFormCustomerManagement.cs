using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Evensel.RetailService;
using EvenselIT.UI.Global;

namespace EvenselIT.UI.subForms
{
    public partial class subFormCustomerManagement : Form
    {
        private CustomerService cstomerService = null;
        private int tabIndex = 0;

        public subFormCustomerManagement()
        {
            InitializeComponent();
        }

        private void subFormCustomerManagement_Load(object sender, EventArgs e)
        {
            cstomerService = new CustomerService();

            tabIndex = tabControllerCustomerManagement.SelectedIndex;
            LoadTabDetails(tabIndex);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerService cusService = new CustomerService();

            try
            {
                Customer obj = new Customer()
                    {
                        ID = Convert.ToInt32(txtID.Text),
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Address = txtAddress.Text,
                        City = txtCity.Text,
                        State = txtState.Text,
                        Country = txtCountry.Text,
                        Email = txtEmail.Text,
                        Phone = txtPhone.Text,
                        mobile = txtMobile.Text
                    };

                cusService.AddNew(obj);
                ClearNewCustomerFields();
                MessageBox.Show(this, "Customer Added.", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer Insert Fail : " + ex.Message);
            }
        }

        private void ClearNewCustomerFields()
        {
            txtID.Text = (cstomerService.getMaxCustomerID() + 1).ToString() ;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtCountry.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtMobile.Text = "";
        }

        private void tabControllerCustomerManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabIndex = tabControllerCustomerManagement.SelectedIndex;
            LoadTabDetails(tabIndex);
        }


        //Load Details to the Tab in occurdance with Tab Selection
        private void LoadTabDetails(int tbIndex)
        {
            switch (tbIndex)
            {
                case 0:
                    LoadCustomerDetails();
                    break;
                case 1:
                    break;
            }
        }

        //Load Customer Details To the Grid
        public void LoadCustomerDetails()
        {
            dGridAllCustomers.DataSource = cstomerService.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dGridAllCustomers.CurrentRow.Cells["ID"].Value.ToString();
            string fName = dGridAllCustomers.CurrentRow.Cells["FirstName"].Value.ToString();
            string LName = dGridAllCustomers.CurrentRow.Cells["LastName"].Value.ToString();
            string name = fName + " " + LName;

            DialogResult result = MessageBox.Show(this, "Are Your Sure You Want to Add \nCustomer ID :" + id + "\nName :" + name, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                //Send Values to the Main Form
                GlobalClass.CustomerID = id;
                GlobalClass.CustomerName = name;
                this.Close();
            }
        }

        private void tabControllerCustomerManagement_Click(object sender, EventArgs e)
        {
            txtID.Text = (cstomerService.getMaxCustomerID() + 1).ToString();
        }

        private void txtEditID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateCustomerDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Customer obj = new Customer();
                obj.ID = Convert.ToInt32(txtEditID.Text);
                obj.FirstName = txtEditFirstName.Text;
                obj.LastName = txtEditLastName.Text;
                obj.Address = txtEditAddress.Text;
                obj.City = txtEditCity.Text;
                obj.State = txtEditState.Text;
                obj.Country = txtEditCountry.Text;
                obj.Email = txtEditAddress.Text;
                obj.Phone = txtEditPhone.Text;
                obj.mobile = txtEditMobile.Text;

                cstomerService.Update(obj);
                ClearCustomerEditFields();

                MessageBox.Show(this, "Sucessfully Updated Customer Details", "Suceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error On Update Customer :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCustomerEditFields()
        {
            txtEditFirstName.Text = "";
            txtEditLastName.Text = "";
            txtEditAddress.Text = "";
            txtEditCity.Text = "";
            txtEditState.Text = "";
            txtEditCountry.Text = "";
            txtEditAddress.Text = "";
            txtEditPhone.Text = "";
            txtEditMobile.Text = "";
        }

        private void txtEditID_Leave(object sender, EventArgs e)
        {
            try
            {
                int customerID = Convert.ToInt32(txtEditID.Text);
                Customer cstomer = cstomerService.GetByID(customerID);

                txtEditFirstName.Text = cstomer.FirstName;
                txtEditLastName.Text = cstomer.LastName;
                txtEditAddress.Text = cstomer.Address;
                txtEditCity.Text = cstomer.City;
                txtEditState.Text = cstomer.State;
                txtEditCountry.Text = cstomer.Country;
                txtEditAddress.Text = cstomer.Email;
                txtEditPhone.Text = cstomer.Phone;
                txtEditMobile.Text = cstomer.mobile;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error On Load Customer Details:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            string ID = dGridAllCustomers.CurrentRow.Cells["ID"].Value.ToString();

            DialogResult result = MessageBox.Show(this,"Are Your Sure You Want to delete\nCustomer with ID "+ID, "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                bool? res = cstomerService.Delete(Convert.ToInt32(ID));

                if (res.Equals(true))
                {                    
                    MessageBox.Show(this, "Sucessfully Delete Customer", "Suceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerDetails();
                }
            }
        }


    }
}
