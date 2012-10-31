using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Evensel.RetailService;
using EvenselIT.UI;
using EvenselIT.UI.Global;

namespace EvenselPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User's Roles list will retun for given valid username and password
        /// </summary>
        /// <param name="sender">UserName, Password</param>
        /// <param name="e">User's Role List</param>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserManager usrManager = new UserManager();
            List<Role> usrRolesList = usrManager.UserAuthentication(txtUserName.Text, txtPassWord.Text);
            if (usrRolesList != null)
            {
                GlobalClass.UserID = usrManager.GetUserID(txtUserName.Text);
                GlobalClass.UserName = txtUserName.Text;

                foreach (var role in usrRolesList)
                {
                    int roleID = role.ID;

                    switch (roleID)
                    {
                        case 1:
                            {
                                this.Hide();
                                mainForm mForm = new mainForm();
                                mForm.Show();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Test");
                                break;
                            }
                    }
                }

            }
            else
            {
                txtUserName.Text = "";
                txtPassWord.Text = "";
                MessageBox.Show("Invalid User");
            }
        }
    }
}
