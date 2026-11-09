namespace Lab1
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnBicycle
            // 
            btnBicycle.FlatStyle = FlatStyle.Flat;
            btnBicycle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBicycle.Location = new Point(207, 175);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(94, 29);
            btnBicycle.TabIndex = 0;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = true;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.FlatStyle = FlatStyle.Flat;
            btnMushroom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMushroom.Location = new Point(532, 179);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(134, 31);
            btnMushroom.TabIndex = 1;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = true;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(335, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 31);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "CHOOSE";
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnMushroom);
            Controls.Add(btnBicycle);
            Name = "ChooseForm";
            Text = "ChooseForm";
            FormClosed += ChooseForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBicycle;
        private Button btnMushroom;
        private Label lblTitle;
    }
}