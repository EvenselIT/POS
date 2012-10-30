using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Evensel.RetailService;

namespace EvenselIT.UI.subForms
{
    public partial class subFormSupplierManagement : Form
    {
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
            
            SupplierManager supMgr = new SupplierManager(); // check values added sucessfully - no exception handling in back end code
            if (supMgr.AddNew(supplier) == 1)
            {
                MessageBox.Show("Successfull","New Supplier Added", MessageBoxButtons.OK);
            }
        }
    }
}
