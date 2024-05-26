using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodManagementSystem
{
    public partial class Payment : Form
    {
        int payPayID, payOrdID, payTotal;
        string payName, payFood, payMethod;
        public Payment()
        {
            InitializeComponent();
            AddMouseEvents(BTNPayAdd);
            AddMouseEvents(BTNPayDelete);
            AddMouseEvents(BTNPayUpdate);
            AddMouseEvents(BTNPayReset);
        }

        private void BTNPayAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBPayPayID.Text) || string.IsNullOrEmpty(TBPayOrdID.Text) || string.IsNullOrEmpty(TBPayName.Text) || string.IsNullOrEmpty(TBPayFood.Text) || (!RBPayCash.Checked && !RBPayCredit.Checked))
            {
                MessageBox.Show("Add some information!", "Failed");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to add this information?", "Adding Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    payPayID = Convert.ToInt32(TBPayPayID.Text);
                    payOrdID = Convert.ToInt32(TBPayOrdID.Text);
                    payName = TBPayName.Text;
                    payFood = TBPayFood.Text;
                    payTotal = Convert.ToInt32(TBPayTotal.Text);



                    if(RBPayCash.Checked)
                    {
                        payMethod = "Cash";
                    }
                    else if(RBPayCredit.Checked)
                    {
                        payMethod = "Credit Card";
                    }

                    MessageBox.Show("Information successfully added!", "Successful");

                    ListBoxPayment.Items.Add(payPayID + (" | ") + payOrdID + (" | ") + payName + (" | ") + payFood + (" | ") + payMethod + (" | ") + payTotal);

                    TBPayPayID.Clear();
                    TBPayOrdID.Clear();
                    TBPayName.Clear();
                    TBPayFood.Clear();
                    TBPayTotal.Clear();
                    RBPayCash.Checked = false;
                    RBPayCredit.Checked = false;

                    DataTable table = new DataTable();
                }
                else
                {
                    MessageBox.Show("Information unsuccessfully added!", "Failed");
                }
            }
        }

        private void BTNPayDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (ListBoxPayment.SelectedIndex != -1)
                {

                    ListBoxPayment.Items.RemoveAt(ListBoxPayment.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete", "Failed");
            }
        }

        private void BTNPayUpdate_Click(object sender, EventArgs e)
        {
            if (ListBoxPayment.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(TBPayPayID.Text) || string.IsNullOrEmpty(TBPayOrdID.Text) || string.IsNullOrEmpty(TBPayName.Text) || string.IsNullOrEmpty(TBPayFood.Text) || (!RBPayCash.Checked && !RBPayCredit.Checked))
                {
                    MessageBox.Show("Add some information!", "Failed");
                }
                else
                {
                    payPayID = Convert.ToInt32(TBPayPayID.Text);
                    payOrdID = Convert.ToInt32(TBPayOrdID.Text);
                    payName = TBPayName.Text;
                    payFood = TBPayFood.Text;
                    payTotal = Convert.ToInt32(TBPayTotal.Text);


                    if (RBPayCash.Checked)
                    {
                        payMethod = "Cash";
                    }
                    else if (RBPayCredit.Checked)
                    {
                        payMethod = "Credit Card";
                    }

                    DialogResult result = MessageBox.Show("Are you sure to update this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        string updateItem = payPayID + (" | ") + payOrdID + (" | ") + payName + (" | ") + payFood + (" | ") + payMethod + (" | ") + payTotal;
                        ListBoxPayment.Items[ListBoxPayment.SelectedIndex] = updateItem;

                        MessageBox.Show("Information successfully updated!", "Successful");

                        TBPayPayID.Clear();
                        TBPayOrdID.Clear();
                        TBPayName.Clear();
                        TBPayFood.Clear();
                        TBPayTotal.Clear();
                        RBPayCash.Checked = false;
                        RBPayCredit.Checked = false;

                    }
                    else
                    {
                        MessageBox.Show("Information unsuccessfully updated!", "Failed");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a row to update", "Failed");
            }
        }

        private void BTNPayReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reset this table?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ListBoxPayment.Items.Clear();
            }
        }

        private void ListBoxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxPayment.SelectedIndex != -1)
            {
                string selectedItem = ListBoxPayment.SelectedItem.ToString();
                string[] parts = selectedItem.Split('|').Select(p => p.Trim()).ToArray();

                if (parts.Length == 6)
                {
                    TBPayPayID.Text = parts[0];
                    TBPayOrdID.Text = parts[1];
                    TBPayName.Text = parts[2];
                    TBPayFood.Text = parts[3];
                    TBPayTotal.Text = parts[5];


                    if (parts[4] == "Cash")
                    {
                        RBPayCash.Checked = true;
                    }
                    else if (parts[4] == "Credit Card")
                    {
                        RBPayCredit.Checked = true;
                    }



                }
            }
        }

        private void AddMouseEvents(Label label, bool isLogout = false)
        {

            label.MouseEnter += (sender, e) => label.BackColor = Color.SlateGray;
            label.MouseLeave += (sender, e) => label.BackColor = Color.MistyRose;

        }
    }
}
