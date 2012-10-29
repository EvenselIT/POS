using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Evensel.RetailService;

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
            List<Role> usrRolesList = usrManager.UserAuthentication(txtUserName.ToString(), txtPassWord.ToString());
            if (usrRolesList != null)
            {
                //if userRoleList is not null then uesr is a valid user cond....
                MessageBox.Show("Valid User");//test
            }
        }
    }
}
