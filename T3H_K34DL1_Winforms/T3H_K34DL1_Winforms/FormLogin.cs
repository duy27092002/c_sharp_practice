using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace T3H_K34DL1_Winforms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string getUsername = txtUsername.Text;
            string getPassword = txtPassword.Text;
            string pass = "123456";
            string username = "admin";

            if (username.Equals(getUsername) && pass.Equals(getPassword))
            {
                lbMess.Text = "Welcome, " + getUsername + "!";
            } else
            {
                lbMess.Text = "Login Failed!";
            }
        }

        private void lbSuggestSigup_Click(object sender, EventArgs e)
        {
            sigupForm sigup = new sigupForm();
            this.Hide();
            sigup.Show();
        }
    }
}
