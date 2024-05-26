namespace FoodManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            BTNActivePayment = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            BTNEmployee = new Label();
            BTNActiveEmployee = new Panel();
            label4 = new Label();
            BTNLogout = new Label();
            BTNOrder = new Label();
            label1 = new Label();
            BTNActiveOrder = new Panel();
            label3 = new Label();
            BTNPayment = new Label();
            panelChildForm = new Panel();
            panel1.SuspendLayout();
            BTNActivePayment.SuspendLayout();
            panel2.SuspendLayout();
            BTNActiveEmployee.SuspendLayout();
            BTNActiveOrder.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(BTNActivePayment);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BTNEmployee);
            panel1.Controls.Add(BTNPayment);
            panel1.Controls.Add(BTNLogout);
            panel1.Controls.Add(BTNActiveOrder);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BTNActiveEmployee);
            panel1.Controls.Add(BTNOrder);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 678);
            panel1.TabIndex = 1;
            // 
            // BTNActivePayment
            // 
            BTNActivePayment.BackColor = SystemColors.ActiveCaptionText;
            BTNActivePayment.Controls.Add(label5);
            BTNActivePayment.Location = new Point(17, 381);
            BTNActivePayment.Name = "BTNActivePayment";
            BTNActivePayment.Size = new Size(5, 44);
            BTNActivePayment.TabIndex = 19;
            BTNActivePayment.Visible = false;
            // 
            // label5
            // 
            label5.Font = new Font("Rockwell Extra Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(940, 11);
            label5.Name = "label5";
            label5.Size = new Size(128, 41);
            label5.TabIndex = 2;
            label5.Text = "HOME";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 590);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 3);
            panel2.TabIndex = 24;
            // 
            // label2
            // 
            label2.Font = new Font("Rockwell Extra Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(940, 11);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 2;
            label2.Text = "HOME";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BTNEmployee
            // 
            BTNEmployee.BackColor = Color.Snow;
            BTNEmployee.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNEmployee.ForeColor = SystemColors.ActiveCaptionText;
            BTNEmployee.Location = new Point(33, 298);
            BTNEmployee.Name = "BTNEmployee";
            BTNEmployee.Size = new Size(145, 46);
            BTNEmployee.TabIndex = 15;
            BTNEmployee.Text = "EMPLOYEE";
            BTNEmployee.TextAlign = ContentAlignment.MiddleCenter;
            BTNEmployee.Click += BTNEmployee_Click;
            // 
            // BTNActiveEmployee
            // 
            BTNActiveEmployee.BackColor = SystemColors.ActiveCaptionText;
            BTNActiveEmployee.Controls.Add(label4);
            BTNActiveEmployee.Location = new Point(17, 300);
            BTNActiveEmployee.Name = "BTNActiveEmployee";
            BTNActiveEmployee.Size = new Size(5, 44);
            BTNActiveEmployee.TabIndex = 18;
            BTNActiveEmployee.Visible = false;
            // 
            // label4
            // 
            label4.Font = new Font("Rockwell Extra Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(940, 11);
            label4.Name = "label4";
            label4.Size = new Size(128, 41);
            label4.TabIndex = 2;
            label4.Text = "HOME";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BTNLogout
            // 
            BTNLogout.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNLogout.ForeColor = Color.Red;
            BTNLogout.Location = new Point(29, 607);
            BTNLogout.Name = "BTNLogout";
            BTNLogout.Size = new Size(145, 35);
            BTNLogout.TabIndex = 23;
            BTNLogout.Text = "LOGOUT";
            BTNLogout.TextAlign = ContentAlignment.MiddleCenter;
            BTNLogout.Click += BTNLogout_Click;
            // 
            // BTNOrder
            // 
            BTNOrder.BackColor = Color.Snow;
            BTNOrder.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNOrder.ForeColor = SystemColors.ActiveCaptionText;
            BTNOrder.Location = new Point(33, 219);
            BTNOrder.Name = "BTNOrder";
            BTNOrder.Size = new Size(145, 46);
            BTNOrder.TabIndex = 14;
            BTNOrder.Text = "ORDER";
            BTNOrder.TextAlign = ContentAlignment.MiddleCenter;
            BTNOrder.Click += BTNOrder_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 105);
            label1.TabIndex = 2;
            label1.Text = "FOOD MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTNActiveOrder
            // 
            BTNActiveOrder.BackColor = SystemColors.ActiveCaptionText;
            BTNActiveOrder.Controls.Add(label3);
            BTNActiveOrder.Location = new Point(17, 220);
            BTNActiveOrder.Name = "BTNActiveOrder";
            BTNActiveOrder.Size = new Size(5, 44);
            BTNActiveOrder.TabIndex = 17;
            // 
            // label3
            // 
            label3.Font = new Font("Rockwell Extra Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(940, 11);
            label3.Name = "label3";
            label3.Size = new Size(128, 41);
            label3.TabIndex = 2;
            label3.Text = "HOME";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BTNPayment
            // 
            BTNPayment.BackColor = Color.Snow;
            BTNPayment.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNPayment.ForeColor = SystemColors.ActiveCaptionText;
            BTNPayment.Location = new Point(33, 379);
            BTNPayment.Name = "BTNPayment";
            BTNPayment.Size = new Size(145, 46);
            BTNPayment.TabIndex = 16;
            BTNPayment.Text = "PAYMENT";
            BTNPayment.TextAlign = ContentAlignment.MiddleCenter;
            BTNPayment.Click += BTNPayment_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.Snow;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(0, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1274, 679);
            panelChildForm.TabIndex = 2;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1274, 679);
            Controls.Add(panel1);
            Controls.Add(panelChildForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            BTNActivePayment.ResumeLayout(false);
            panel2.ResumeLayout(false);
            BTNActiveEmployee.ResumeLayout(false);
            BTNActiveOrder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelChildForm;
        private Panel panel2;
        private Label label2;
        private Label BTNLogout;
        private Panel BTNActivePayment;
        private Label label5;
        private Label BTNEmployee;
        private Panel BTNActiveEmployee;
        private Label label4;
        private Label BTNOrder;
        private Panel BTNActiveOrder;
        private Label label3;
        private Label BTNPayment;
    }
}