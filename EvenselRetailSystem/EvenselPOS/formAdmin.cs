using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EvenselIT.UI.subFormsAdmin;

namespace EvenselIT.UI
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            subFormInventoryManagement inventoryMgt = new subFormInventoryManagement();
            inventoryMgt.ShowDialog();
        }
    }
}
