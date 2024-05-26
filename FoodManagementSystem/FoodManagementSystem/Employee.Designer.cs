namespace FoodManagementSystem
{
    partial class Employee
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
            panel4 = new Panel();
            TBEmpAge = new TextBox();
            TBEmpName = new TextBox();
            TBEmpID = new TextBox();
            BTNEmpReset = new Label();
            BTNEmpUpdate = new Label();
            BTNEmpDelete = new Label();
            BTNEmpAdd = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            ListBoxEmployee = new ListBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.Controls.Add(TBEmpAge);
            panel4.Controls.Add(TBEmpName);
            panel4.Controls.Add(TBEmpID);
            panel4.Controls.Add(BTNEmpReset);
            panel4.Controls.Add(BTNEmpUpdate);
            panel4.Controls.Add(BTNEmpDelete);
            panel4.Controls.Add(BTNEmpAdd);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(ListBoxEmployee);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(194, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 681);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // TBEmpAge
            // 
            TBEmpAge.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBEmpAge.Location = new Point(705, 400);
            TBEmpAge.Name = "TBEmpAge";
            TBEmpAge.Size = new Size(140, 27);
            TBEmpAge.TabIndex = 35;
            // 
            // TBEmpName
            // 
            TBEmpName.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBEmpName.Location = new Point(240, 461);
            TBEmpName.Name = "TBEmpName";
            TBEmpName.Size = new Size(305, 27);
            TBEmpName.TabIndex = 34;
            // 
            // TBEmpID
            // 
            TBEmpID.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBEmpID.Location = new Point(240, 400);
            TBEmpID.Name = "TBEmpID";
            TBEmpID.Size = new Size(107, 27);
            TBEmpID.TabIndex = 32;
            TBEmpID.TextChanged += TBEmpID_TextChanged;
            // 
            // BTNEmpReset
            // 
            BTNEmpReset.BackColor = Color.MistyRose;
            BTNEmpReset.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNEmpReset.ForeColor = SystemColors.ActiveCaptionText;
            BTNEmpReset.Location = new Point(833, 567);
            BTNEmpReset.Name = "BTNEmpReset";
            BTNEmpReset.Size = new Size(145, 46);
            BTNEmpReset.TabIndex = 31;
            BTNEmpReset.Text = "RESET";
            BTNEmpReset.TextAlign = ContentAlignment.MiddleCenter;
            BTNEmpReset.Click += BTNEmpReset_Click;
            // 
            // BTNEmpUpdate
            // 
            BTNEmpUpdate.BackColor = Color.MistyRose;
            BTNEmpUpdate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNEmpUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BTNEmpUpdate.Location = new Point(606, 567);
            BTNEmpUpdate.Name = "BTNEmpUpdate";
            BTNEmpUpdate.Size = new Size(145, 46);
            BTNEmpUpdate.TabIndex = 30;
            BTNEmpUpdate.Text = "UPDATE";
            BTNEmpUpdate.TextAlign = ContentAlignment.MiddleCenter;
            BTNEmpUpdate.Click += BTNEmpUpdate_Click;
            // 
            // BTNEmpDelete
            // 
            BTNEmpDelete.BackColor = Color.MistyRose;
            BTNEmpDelete.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNEmpDelete.ForeColor = SystemColors.ActiveCaptionText;
            BTNEmpDelete.Location = new Point(321, 567);
            BTNEmpDelete.Name = "BTNEmpDelete";
            BTNEmpDelete.Size = new Size(145, 46);
            BTNEmpDelete.TabIndex = 29;
            BTNEmpDelete.Text = "DELETE";
            BTNEmpDelete.TextAlign = ContentAlignment.MiddleCenter;
            BTNEmpDelete.Click += BTNEmpDelete_Click;
            // 
            // BTNEmpAdd
            // 
            BTNEmpAdd.BackColor = Color.MistyRose;
            BTNEmpAdd.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNEmpAdd.ForeColor = SystemColors.ActiveCaptionText;
            BTNEmpAdd.Location = new Point(98, 567);
            BTNEmpAdd.Name = "BTNEmpAdd";
            BTNEmpAdd.Size = new Size(145, 46);
            BTNEmpAdd.TabIndex = 28;
            BTNEmpAdd.Text = "ADD";
            BTNEmpAdd.TextAlign = ContentAlignment.MiddleCenter;
            BTNEmpAdd.Click += BTNEmpAdd_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(650, 391);
            label7.Name = "label7";
            label7.Size = new Size(49, 44);
            label7.TabIndex = 27;
            label7.Text = "AGE:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(170, 452);
            label4.Name = "label4";
            label4.Size = new Size(59, 44);
            label4.TabIndex = 24;
            label4.Text = "NAME:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(119, 391);
            label3.Name = "label3";
            label3.Size = new Size(115, 44);
            label3.TabIndex = 23;
            label3.Text = "EMPLOYEE ID:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListBoxEmployee
            // 
            ListBoxEmployee.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxEmployee.FormattingEnabled = true;
            ListBoxEmployee.ItemHeight = 22;
            ListBoxEmployee.Location = new Point(17, 70);
            ListBoxEmployee.Name = "ListBoxEmployee";
            ListBoxEmployee.Size = new Size(1043, 268);
            ListBoxEmployee.TabIndex = 22;
            ListBoxEmployee.SelectedIndexChanged += ListBoxEmployee_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(880, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 3);
            panel1.TabIndex = 5;
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
            // label1
            // 
            label1.Font = new Font("Rockwell Extra Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(870, 11);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 2;
            label1.Text = "EMPLOYEE";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1274, 679);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox TBEmpAge;
        private TextBox TBEmpName;
        private TextBox TBEmpID;
        private Label BTNEmpReset;
        private Label BTNEmpUpdate;
        private Label BTNEmpDelete;
        private Label BTNEmpAdd;
        private Label label7;
        private Label label4;
        private Label label3;
        private ListBox ListBoxEmployee;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}