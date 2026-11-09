using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ChooseForm : Form
    {
        public LoginForm loginForm;

        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm();
            bicycle.loginForm = this.loginForm;
            bicycle.chooseForm = this;
            bicycle.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm();
            mushroom.loginForm = this.loginForm;
            mushroom.chooseForm = this;
            mushroom.Show();
            this.Hide();
        }
        private void ChooseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginForm.Visible) Application.Exit();
        }
    }
}