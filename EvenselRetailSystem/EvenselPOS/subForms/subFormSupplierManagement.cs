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
    public partial class subFormSupplierManagement : Form
    {
        SupplierManager supMgr = new SupplierManager();
        private int tabIndex = -1;

        public subFormSupplierManagement()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            // new supplier details from user inputs
            // need validation for user inputs
            Supplier supplier = new Supplier();
            supplier.SupplierName = txtSupplierName.Text;
            supplier.Address = rtxtSupplierAddress.Text;
            supplier.Tel = txtSupplierTelephoneNo.Text;
            supplier.AccountNo = txtSupplierTelephoneNo.Text;
            // supplier email is not captured form user

            // check values added sucessfully - no exception handling in back end code
            if (supMgr.AddNew(supplier) == 1)
            {
                MessageBox.Show(this, "New Supplier Added Sucessfully", "Suceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearScreen("new");
            }

        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            Supplier updateSupplier = new Supplier();
            updateSupplier.ID = Convert.ToInt32(txtSupId.Text);
            updateSupplier.SupplierName = txtSupName.Text;
            updateSupplier.Address = rtxtSupAddress.Text;
            updateSupplier.Tel = txtSupTelephoneNo.Text;
            updateSupplier.AccountNo = txtSupAccNo.Text;

            if (supMgr.Update(updateSupplier) == true)
            {
                MessageBox.Show(this, "Supplier Updated Sucessfully", "Suceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearScreen("update");
            }

        }

        private void clearScreen(string screen)
        {
            if (screen == "update")
            {
                txtSupId.Text = "";
                txtSupName.Text = "";
                txtSupAccNo.Text = "";
                rtxtSupAddress.Text = "";
                txtSupTelephoneNo.Text = "";
            }

            if (screen == "new")
            {
                txtSupplierId.Text = "";
                txtSupplierName.Text = "";
                txtSupplierAccNo.Text = "";
                rtxtSupplierAddress.Text = "";
                txtSupTelephoneNo.Text = "";
            }

        }

        private void subFormSupplierManagement_Load(object sender, EventArgs e)
        {
            tabIndex = tabControlSupplierManagement.SelectedIndex;
            if (tabIndex == 0)
            {
                dGridAllSuppliers.DataSource = supMgr.SelectAll();
            }
            if (tabIndex == 1)
            {
                txtSupplierId.Text = Convert.ToString(supMgr.getMaxSupplierID() + 1);
            }
        }
    }
}
