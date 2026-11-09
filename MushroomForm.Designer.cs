namespace Lab1
{
    partial class MushroomForm
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
            lblHelp = new Label();
            lblCount = new Label();
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            btnLogout = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(356, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mushroom";
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Location = new Point(234, 81);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(392, 20);
            lblHelp.TabIndex = 1;
            lblHelp.Text = "Think of one of the six mushrooms, then answer Yes or No.";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(345, 120);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(164, 20);
            lblCount.TabIndex = 2;
            lblCount.Text = "Question 1 of at most 3";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(389, 159);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(68, 20);
            lblQuestion.TabIndex = 3;
            lblQuestion.Text = "Question";
            // 
            // btnYes
            // 
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.Location = new Point(234, 253);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(94, 29);
            btnYes.TabIndex = 4;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.Location = new Point(470, 253);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 29);
            btnNo.TabIndex = 5;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(470, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 46);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(234, 400);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 46);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(951, 490);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblQuestion);
            Controls.Add(lblCount);
            Controls.Add(lblHelp);
            Controls.Add(lblTitle);
            Name = "MushroomForm";
            Text = "MushroomForm";
            FormClosed += MushroomForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblHelp;
        private Label lblCount;
        private Label lblQuestion;
        private Button btnYes;
        private Button btnNo;
        private Button btnLogout;
        private Button btnBack;
    }
}