using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                txtUsername.Clear();
                txtPassword.Clear();

                ChooseForm choose = new ChooseForm();
                choose.loginForm = this;     // so Choose can get back to Login
                choose.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Login failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
    