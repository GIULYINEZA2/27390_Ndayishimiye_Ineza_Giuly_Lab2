using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class BicycleForm : Form
    {
        public LoginForm loginForm;
        public ChooseForm chooseForm;

        public BicycleForm()
        {
            InitializeComponent();
        }

        // Rent for ONE hour, depending on the time of day
        private static int RatePerHour(int hour)
        {
            if (hour < 7 || hour >= 21) return 500;    // 0-7 and 21-24
            if (hour < 14 || hour >= 19) return 1000;  // 7-14 and 19-21
            return 1500;                               // 14-19
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start;
            int end;

            // TryParse fails for decimals like 3.5 and for letters
            if (!int.TryParse(txtStart.Text.Trim(), out start) ||
                !int.TryParse(txtEnd.Text.Trim(), out end))
            {
                MessageBox.Show("Please enter whole numbers only (decimals are not accepted).");
                txtTotal.Clear();
                return;
            }
            if (start < 0 || start > 23)
            {
                MessageBox.Show("The start hour must be between 0 and 23.");
                txtTotal.Clear();
                return;
            }
            if (end < 1 || end > 24)
            {
                MessageBox.Show("The end hour must be between 1 and 24.");
                txtTotal.Clear();
                return;
            }
            if (start >= end)
            {
                MessageBox.Show("The start hour must be less than the end hour.");
                txtTotal.Clear();
                return;
            }

            // Add up the rent for every hour from start to end
            int total = 0;
            for (int hour = start; hour < end; hour++)
            {
                total = total + RatePerHour(hour);
            }
            txtTotal.Text = total.ToString("N0") + " RWF";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();     // show Login FIRST
            chooseForm.Close();   // close the hidden Choose form
            this.Close();         // close this form
        }

        private void BicycleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginForm.Visible) Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            chooseForm.Show();
            this.Hide();
        }
    }
}