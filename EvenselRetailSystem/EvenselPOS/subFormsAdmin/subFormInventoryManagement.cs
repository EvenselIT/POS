using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Evensel.RetailService;

namespace EvenselIT.UI.subFormsAdmin
{
    public partial class subFormInventoryManagement : Form
    {
        private ItemManager itemManager = null;

        public subFormInventoryManagement()
        {
            InitializeComponent();
            IntitializeObjects();
        }

        private void IntitializeObjects()
        {
            itemManager = new ItemManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item newItem = new Item()
            {
                ID = Convert.ToInt32(txtItemID.Text),
                Name = txtItemName.Text,
                ItemCode = txtItemCode.Text,
                Description = txtDescription.Text,
                CostPrice = Convert.ToDecimal(txtCostPrice.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                Category = cmbCategory.SelectedText,
                IsActive = chkActive.Checked
            };

            int res = itemManager.AddNew(newItem);

            if (res == 1)
            {
                MessageBox.Show(this, "Item Successfully Added", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Item Failed to Add", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            txtItemID.Text = (itemManager.getMaxID()+1).ToString();
        }
    }
}
