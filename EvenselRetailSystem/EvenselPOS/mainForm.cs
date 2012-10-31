using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EvenselPOS;
using EvenselIT.UI.Global;
using EvenselIT.UI.subForms;

namespace EvenselIT.UI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            lblLogin.Text = "Logged User : ";
            Form1 logInForm = new Form1();
            logInForm.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            lblLogin.Text += GlobalClass.UserName;
        }

        private void btnCustomerManagment_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.98;
            subFormCustomerManagement cusMgnForm = new subFormCustomerManagement();
            cusMgnForm.ShowDialog();
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
            if (GlobalClass.CustomerID != null)
            {
                lblCustomerIdOut.Text = ": " + GlobalClass.CustomerID;
                lblCustomerNameOut.Text = ": " + GlobalClass.CustomerName;
            }
        }
    }
}
