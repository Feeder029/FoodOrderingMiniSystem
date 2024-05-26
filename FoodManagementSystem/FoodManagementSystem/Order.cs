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
    public partial class Order : Form
    {
        int ordID;
        float ordPrice;
        string ordName, ordFood;

        public Order()
        {
            InitializeComponent();

            AddMouseEvents(BTNOrdAdd);
            AddMouseEvents(BTNOrdDelete);
            AddMouseEvents(BTNOrdUpdate);
            AddMouseEvents(BTNOrdReset);
        }

        private void BTNOrdAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBOrdID.Text) || string.IsNullOrEmpty(TBOrdName.Text) || string.IsNullOrEmpty(TBOrdFood.Text) || string.IsNullOrEmpty(TBOrdPrice.Text))
            {
                MessageBox.Show("Add some information!", "Failed");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to add this information?", "Adding Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    ordID = Convert.ToInt32(TBOrdID.Text);
                    ordName = TBOrdName.Text;
                    ordFood = TBOrdFood.Text;
                    ordPrice = float.Parse(TBOrdPrice.Text);

                    MessageBox.Show("Information successfully added!", "Successful");
                    ListBoxOrder.Items.Add(ordID + (" | ") + ordName + (" | ") + ordFood + (" | ") + ordPrice);

                    TBOrdID.Clear();
                    TBOrdName.Clear();
                    TBOrdFood.Clear();
                    TBOrdPrice.Clear();

                    DataTable table = new DataTable();
                }
                else
                {
                    MessageBox.Show("Information unsuccessfully added!", "Failed");
                }
            }
        }

        private void BTNOrdDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (ListBoxOrder.SelectedIndex != -1)
                {
                    ListBoxOrder.Items.RemoveAt(ListBoxOrder.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete", "Failed");
            }
        }

        private void BTNOrdUpdate_Click(object sender, EventArgs e)
        {
            if (ListBoxOrder.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(TBOrdID.Text) || string.IsNullOrEmpty(TBOrdName.Text) || string.IsNullOrEmpty(TBOrdFood.Text) || string.IsNullOrEmpty(TBOrdPrice.Text))
                {
                    MessageBox.Show("Add some information!", "Failed");
                }
                else
                {
                    ordID = Convert.ToInt32(TBOrdID.Text);
                    ordName = TBOrdName.Text;
                    ordFood = TBOrdFood.Text;
                    ordPrice = float.Parse(TBOrdPrice.Text);

                    DialogResult result = MessageBox.Show("Are you sure to update this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        string updateItem = ordID + (" | ") + ordName + (" | ") + ordFood + (" | ") + ordPrice;
                        ListBoxOrder.Items[ListBoxOrder.SelectedIndex] = updateItem;

                        MessageBox.Show("Information successfully updated!", "Successful");

                        TBOrdID.Clear();
                        TBOrdName.Clear();
                        TBOrdFood.Clear();
                        TBOrdPrice.Clear();
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

        private void BTNOrdReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reset this table?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ListBoxOrder.Items.Clear();
            }
        }

        private void ListBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxOrder.SelectedIndex != -1)
            {
                string selectedItem = ListBoxOrder.SelectedItem.ToString();
                string[] parts = selectedItem.Split('|').Select(p => p.Trim()).ToArray();

                if (parts.Length == 4)
                {
                    TBOrdID.Text = parts[0];
                    TBOrdName.Text = parts[1];
                    TBOrdFood.Text = parts[2];
                    TBOrdPrice.Text = parts[3];
                }
            }
        }

        //Hover
        private void AddMouseEvents(Label label, bool isLogout = false)
        {

            label.MouseEnter += (sender, e) => label.BackColor = Color.SlateGray;
            label.MouseLeave += (sender, e) => label.BackColor = Color.MistyRose;

        }
    }
}
