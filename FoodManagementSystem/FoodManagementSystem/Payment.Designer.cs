namespace FoodManagementSystem
{
    partial class Payment
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
            GroupRB = new GroupBox();
            RBPayCash = new RadioButton();
            RBPayCredit = new RadioButton();
            TBPayOrdID = new TextBox();
            label6 = new Label();
            TBPayTotal = new TextBox();
            TBPayName = new TextBox();
            TBPayFood = new TextBox();
            TBPayPayID = new TextBox();
            BTNPayReset = new Label();
            BTNPayUpdate = new Label();
            BTNPayDelete = new Label();
            BTNPayAdd = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ListBoxPayment = new ListBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel4.SuspendLayout();
            GroupRB.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.Controls.Add(GroupRB);
            panel4.Controls.Add(TBPayOrdID);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(TBPayTotal);
            panel4.Controls.Add(TBPayName);
            panel4.Controls.Add(TBPayFood);
            panel4.Controls.Add(TBPayPayID);
            panel4.Controls.Add(BTNPayReset);
            panel4.Controls.Add(BTNPayUpdate);
            panel4.Controls.Add(BTNPayDelete);
            panel4.Controls.Add(BTNPayAdd);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(ListBoxPayment);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(194, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 681);
            panel4.TabIndex = 8;
            // 
            // GroupRB
            // 
            GroupRB.Controls.Add(RBPayCash);
            GroupRB.Controls.Add(RBPayCredit);
            GroupRB.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GroupRB.Location = new Point(655, 362);
            GroupRB.Name = "GroupRB";
            GroupRB.Size = new Size(171, 100);
            GroupRB.TabIndex = 41;
            GroupRB.TabStop = false;
            GroupRB.Text = "PAYMENT METHOD:";
            // 
            // RBPayCash
            // 
            RBPayCash.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RBPayCash.Location = new Point(26, 24);
            RBPayCash.Name = "RBPayCash";
            RBPayCash.Size = new Size(146, 30);
            RBPayCash.TabIndex = 39;
            RBPayCash.TabStop = true;
            RBPayCash.Text = "CASH";
            RBPayCash.UseVisualStyleBackColor = true;
            // 
            // RBPayCredit
            // 
            RBPayCredit.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RBPayCredit.Location = new Point(26, 55);
            RBPayCredit.Name = "RBPayCredit";
            RBPayCredit.Size = new Size(146, 30);
            RBPayCredit.TabIndex = 40;
            RBPayCredit.TabStop = true;
            RBPayCredit.Text = "CREDIT CARD";
            RBPayCredit.UseVisualStyleBackColor = true;
            // 
            // TBPayOrdID
            // 
            TBPayOrdID.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPayOrdID.Location = new Point(186, 408);
            TBPayOrdID.Name = "TBPayOrdID";
            TBPayOrdID.Size = new Size(191, 27);
            TBPayOrdID.TabIndex = 37;
            // 
            // label6
            // 
            label6.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(88, 403);
            label6.Name = "label6";
            label6.Size = new Size(92, 26);
            label6.TabIndex = 36;
            label6.Text = "ORDER ID:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TBPayTotal
            // 
            TBPayTotal.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPayTotal.Location = new Point(737, 497);
            TBPayTotal.Name = "TBPayTotal";
            TBPayTotal.Size = new Size(145, 27);
            TBPayTotal.TabIndex = 35;
            // 
            // TBPayName
            // 
            TBPayName.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPayName.Location = new Point(186, 451);
            TBPayName.Name = "TBPayName";
            TBPayName.Size = new Size(301, 27);
            TBPayName.TabIndex = 34;
            // 
            // TBPayFood
            // 
            TBPayFood.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPayFood.Location = new Point(186, 494);
            TBPayFood.Name = "TBPayFood";
            TBPayFood.Size = new Size(247, 27);
            TBPayFood.TabIndex = 33;
            // 
            // TBPayPayID
            // 
            TBPayPayID.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPayPayID.Location = new Point(186, 362);
            TBPayPayID.Name = "TBPayPayID";
            TBPayPayID.Size = new Size(191, 27);
            TBPayPayID.TabIndex = 32;
            // 
            // BTNPayReset
            // 
            BTNPayReset.BackColor = Color.MistyRose;
            BTNPayReset.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNPayReset.ForeColor = SystemColors.ActiveCaptionText;
            BTNPayReset.Location = new Point(833, 567);
            BTNPayReset.Name = "BTNPayReset";
            BTNPayReset.Size = new Size(145, 46);
            BTNPayReset.TabIndex = 31;
            BTNPayReset.Text = "RESET";
            BTNPayReset.TextAlign = ContentAlignment.MiddleCenter;
            BTNPayReset.Click += BTNPayReset_Click;
            // 
            // BTNPayUpdate
            // 
            BTNPayUpdate.BackColor = Color.MistyRose;
            BTNPayUpdate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNPayUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BTNPayUpdate.Location = new Point(606, 567);
            BTNPayUpdate.Name = "BTNPayUpdate";
            BTNPayUpdate.Size = new Size(145, 46);
            BTNPayUpdate.TabIndex = 30;
            BTNPayUpdate.Text = "UPDATE";
            BTNPayUpdate.TextAlign = ContentAlignment.MiddleCenter;
            BTNPayUpdate.Click += BTNPayUpdate_Click;
            // 
            // BTNPayDelete
            // 
            BTNPayDelete.BackColor = Color.MistyRose;
            BTNPayDelete.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNPayDelete.ForeColor = SystemColors.ActiveCaptionText;
            BTNPayDelete.Location = new Point(321, 567);
            BTNPayDelete.Name = "BTNPayDelete";
            BTNPayDelete.Size = new Size(145, 46);
            BTNPayDelete.TabIndex = 29;
            BTNPayDelete.Text = "DELETE";
            BTNPayDelete.TextAlign = ContentAlignment.MiddleCenter;
            BTNPayDelete.Click += BTNPayDelete_Click;
            // 
            // BTNPayAdd
            // 
            BTNPayAdd.BackColor = Color.MistyRose;
            BTNPayAdd.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNPayAdd.ForeColor = SystemColors.ActiveCaptionText;
            BTNPayAdd.Location = new Point(98, 567);
            BTNPayAdd.Name = "BTNPayAdd";
            BTNPayAdd.Size = new Size(145, 46);
            BTNPayAdd.TabIndex = 28;
            BTNPayAdd.Text = "ADD";
            BTNPayAdd.TextAlign = ContentAlignment.MiddleCenter;
            BTNPayAdd.Click += BTNPayAdd_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(599, 493);
            label7.Name = "label7";
            label7.Size = new Size(148, 35);
            label7.TabIndex = 27;
            label7.Text = "TOTAL AMOUNT: ";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(118, 497);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 25;
            label5.Text = "FOOD:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(118, 451);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 24;
            label4.Text = "NAME:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 362);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 23;
            label3.Text = "PAYMENT ID:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListBoxPayment
            // 
            ListBoxPayment.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxPayment.FormattingEnabled = true;
            ListBoxPayment.ItemHeight = 22;
            ListBoxPayment.Location = new Point(17, 70);
            ListBoxPayment.Name = "ListBoxPayment";
            ListBoxPayment.Size = new Size(1043, 268);
            ListBoxPayment.TabIndex = 22;
            ListBoxPayment.SelectedIndexChanged += ListBoxPayment_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(900, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 3);
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
            label1.Location = new Point(888, 11);
            label1.Name = "label1";
            label1.Size = new Size(180, 41);
            label1.TabIndex = 2;
            label1.Text = "PAYMENT";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1274, 679);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            GroupRB.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox TBPayTotal;
        private TextBox TBPayName;
        private TextBox TBPayFood;
        private TextBox TBPayPayID;
        private Label BTNPayReset;
        private Label BTNPayUpdate;
        private Label BTNPayDelete;
        private Label BTNPayAdd;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListBox ListBoxPayment;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private GroupBox GroupRB;
        private RadioButton RBPayCash;
        private RadioButton RBPayCredit;
        private TextBox TBPayOrdID;
        private Label label6;
    }
}