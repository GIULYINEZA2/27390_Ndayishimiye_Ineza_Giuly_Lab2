namespace Lab1
{
    partial class BicycleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblRates = new Label();
            lblStart = new Label();
            txtStart = new TextBox();
            lblEnd = new Label();
            txtEnd = new TextBox();
            btnCalculate = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnLogout = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(311, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(89, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bicycle";
            // 
            // lblRates
            // 
            lblRates.AutoSize = true;
            lblRates.Location = new Point(96, 91);
            lblRates.Name = "lblRates";
            lblRates.Size = new Size(563, 20);
            lblRates.TabIndex = 1;
            lblRates.Text = "Rent per hour: 0-7 and 21-24: 500 RWF, 7-14 and 19-21: 1000 RWF, 14-19: 1500 RWF";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(96, 172);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(126, 20);
            lblStart.TabIndex = 2;
            lblStart.Text = "Start hour (0 - 23)";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(311, 172);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(125, 27);
            txtStart.TabIndex = 3;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(102, 249);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(120, 20);
            lblEnd.TabIndex = 4;
            lblEnd.Text = "End hour (1 - 24)";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(311, 249);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(125, 27);
            txtEnd.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.Black;
            btnCalculate.Location = new Point(329, 310);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(163, 365);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(311, 358);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(481, 435);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(207, 446);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // BicycleForm
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(823, 523);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnd);
            Controls.Add(lblEnd);
            Controls.Add(txtStart);
            Controls.Add(lblStart);
            Controls.Add(lblRates);
            Controls.Add(lblTitle);
            Name = "BicycleForm";
            Text = "BicycleForm";
            FormClosed += BicycleForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRates;
        private Label lblStart;
        private TextBox txtStart;
        private Label lblEnd;
        private TextBox txtEnd;
        private Button button1;
        private Button btnCalculate;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnLogout;
        private Button btnBack;
    }
}