namespace FoodManagementSystem
{
    partial class Order
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
            button1 = new Button();
            panel4 = new Panel();
            TBOrdPrice = new TextBox();
            TBOrdName = new TextBox();
            TBOrdFood = new TextBox();
            TBOrdID = new TextBox();
            BTNOrdReset = new Label();
            BTNOrdUpdate = new Label();
            BTNOrdDelete = new Label();
            BTNOrdAdd = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ListBoxOrder = new ListBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(538, 333);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.Controls.Add(TBOrdPrice);
            panel4.Controls.Add(TBOrdName);
            panel4.Controls.Add(TBOrdFood);
            panel4.Controls.Add(TBOrdID);
            panel4.Controls.Add(BTNOrdReset);
            panel4.Controls.Add(BTNOrdUpdate);
            panel4.Controls.Add(BTNOrdDelete);
            panel4.Controls.Add(BTNOrdAdd);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(ListBoxOrder);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(194, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 681);
            panel4.TabIndex = 7;
            // 
            // TBOrdPrice
            // 
            TBOrdPrice.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBOrdPrice.Location = new Point(693, 435);
            TBOrdPrice.Name = "TBOrdPrice";
            TBOrdPrice.Size = new Size(158, 27);
            TBOrdPrice.TabIndex = 35;
            TBOrdPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // TBOrdName
            // 
            TBOrdName.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBOrdName.Location = new Point(168, 435);
            TBOrdName.Name = "TBOrdName";
            TBOrdName.Size = new Size(262, 27);
            TBOrdName.TabIndex = 34;
            // 
            // TBOrdFood
            // 
            TBOrdFood.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBOrdFood.Location = new Point(693, 394);
            TBOrdFood.Name = "TBOrdFood";
            TBOrdFood.Size = new Size(262, 27);
            TBOrdFood.TabIndex = 33;
            // 
            // TBOrdID
            // 
            TBOrdID.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBOrdID.Location = new Point(168, 394);
            TBOrdID.Name = "TBOrdID";
            TBOrdID.Size = new Size(191, 27);
            TBOrdID.TabIndex = 32;
            // 
            // BTNOrdReset
            // 
            BTNOrdReset.BackColor = Color.MistyRose;
            BTNOrdReset.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNOrdReset.ForeColor = SystemColors.ActiveCaptionText;
            BTNOrdReset.Location = new Point(833, 567);
            BTNOrdReset.Name = "BTNOrdReset";
            BTNOrdReset.Size = new Size(145, 46);
            BTNOrdReset.TabIndex = 31;
            BTNOrdReset.Text = "RESET";
            BTNOrdReset.TextAlign = ContentAlignment.MiddleCenter;
            BTNOrdReset.Click += BTNOrdReset_Click;
            // 
            // BTNOrdUpdate
            // 
            BTNOrdUpdate.BackColor = Color.MistyRose;
            BTNOrdUpdate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNOrdUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BTNOrdUpdate.Location = new Point(606, 567);
            BTNOrdUpdate.Name = "BTNOrdUpdate";
            BTNOrdUpdate.Size = new Size(145, 46);
            BTNOrdUpdate.TabIndex = 30;
            BTNOrdUpdate.Text = "UPDATE";
            BTNOrdUpdate.TextAlign = ContentAlignment.MiddleCenter;
            BTNOrdUpdate.Click += BTNOrdUpdate_Click;
            // 
            // BTNOrdDelete
            // 
            BTNOrdDelete.BackColor = Color.MistyRose;
            BTNOrdDelete.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNOrdDelete.ForeColor = SystemColors.ActiveCaptionText;
            BTNOrdDelete.Location = new Point(321, 567);
            BTNOrdDelete.Name = "BTNOrdDelete";
            BTNOrdDelete.Size = new Size(145, 46);
            BTNOrdDelete.TabIndex = 29;
            BTNOrdDelete.Text = "DELETE";
            BTNOrdDelete.TextAlign = ContentAlignment.MiddleCenter;
            BTNOrdDelete.Click += BTNOrdDelete_Click;
            // 
            // BTNOrdAdd
            // 
            BTNOrdAdd.BackColor = Color.MistyRose;
            BTNOrdAdd.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNOrdAdd.ForeColor = SystemColors.ActiveCaptionText;
            BTNOrdAdd.Location = new Point(98, 567);
            BTNOrdAdd.Name = "BTNOrdAdd";
            BTNOrdAdd.Size = new Size(145, 46);
            BTNOrdAdd.TabIndex = 28;
            BTNOrdAdd.Text = "ADD";
            BTNOrdAdd.TextAlign = ContentAlignment.MiddleCenter;
            BTNOrdAdd.Click += BTNOrdAdd_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(629, 426);
            label7.Name = "label7";
            label7.Size = new Size(58, 44);
            label7.TabIndex = 27;
            label7.Text = "PRICE:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(623, 383);
            label5.Name = "label5";
            label5.Size = new Size(58, 44);
            label5.TabIndex = 25;
            label5.Text = "FOOD:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 424);
            label4.Name = "label4";
            label4.Size = new Size(61, 44);
            label4.TabIndex = 24;
            label4.Text = "NAME:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 385);
            label3.Name = "label3";
            label3.Size = new Size(92, 44);
            label3.TabIndex = 23;
            label3.Text = "ORDER ID:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListBoxOrder
            // 
            ListBoxOrder.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxOrder.FormattingEnabled = true;
            ListBoxOrder.ItemHeight = 22;
            ListBoxOrder.Location = new Point(17, 70);
            ListBoxOrder.Name = "ListBoxOrder";
            ListBoxOrder.Size = new Size(1043, 268);
            ListBoxOrder.TabIndex = 22;
            ListBoxOrder.SelectedIndexChanged += ListBoxOrder_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(943, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(118, 3);
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
            label1.Text = "ORDER";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1274, 679);
            Controls.Add(panel4);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel4;
        private TextBox TBOrdPrice;
        private TextBox TBOrdName;
        private TextBox TBOrdFood;
        private TextBox TBOrdID;
        private Label BTNOrdReset;
        private Label BTNOrdUpdate;
        private Label BTNOrdDelete;
        private Label BTNOrdAdd;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListBox ListBoxOrder;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}