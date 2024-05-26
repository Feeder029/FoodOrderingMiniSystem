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
    public partial class Employee : Form
    {
        int empID, empAge;
        string empName;
        public Employee()
        {
            InitializeComponent();
            AddMouseEvents(BTNEmpAdd);
            AddMouseEvents(BTNEmpDelete);
            AddMouseEvents(BTNEmpUpdate);
            AddMouseEvents(BTNEmpReset);
        }

        private void TBEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNEmpAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TBEmpID.Text) || string.IsNullOrEmpty(TBEmpName.Text) || string.IsNullOrEmpty(TBEmpAge.Text))
            {
                MessageBox.Show("Add some information!", "Failed");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to add this information?", "Adding Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    empID = Convert.ToInt32(TBEmpID.Text);
                    empName = TBEmpName.Text;
                    empAge = Convert.ToInt32(TBEmpAge.Text);

                    MessageBox.Show("Information successfully added!", "Successful");

                    ListBoxEmployee.Items.Add(empID + (" | ") + empName + (" | ") + empAge);

                    TBEmpID.Clear();
                    TBEmpName.Clear();
                    TBEmpAge.Clear();

                    DataTable table = new DataTable();
                }
                else
                {
                    MessageBox.Show("Information unsuccessfully added!", "Failed");
                }
            }
        }

        private void BTNEmpDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if(ListBoxEmployee.SelectedIndex != -1)
                {
                    ListBoxEmployee.Items.RemoveAt(ListBoxEmployee.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete", "Failed");
            }
        }

        private void BTNEmpUpdate_Click(object sender, EventArgs e)
        {
            if(ListBoxEmployee.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(TBEmpID.Text) || string.IsNullOrEmpty(TBEmpName.Text) || string.IsNullOrEmpty(TBEmpAge.Text))
                {
                    MessageBox.Show("Add some information!", "Failed");
                }
                else
                {
                    empID = Convert.ToInt32(TBEmpID.Text);
                    empName = TBEmpName.Text;
                    empAge = Convert.ToInt32(TBEmpAge.Text);

                    DialogResult result = MessageBox.Show("Are you sure to update this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if(result == DialogResult.OK)
                    {
                        string updateItems = empID + (" | ") + empName + (" | ") + empAge;
                        ListBoxEmployee.Items[ListBoxEmployee.SelectedIndex] = updateItems;

                        MessageBox.Show("Information successfully updated!", "Successful");


                        TBEmpID.Clear();
                        TBEmpName.Clear();
                        TBEmpAge.Clear();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNEmpReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reset this table?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ListBoxEmployee.Items.Clear();
            }
        }

        private void ListBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBoxEmployee.SelectedIndex != -1)
            {
                string selectedItem = ListBoxEmployee.SelectedItem.ToString();
                string[] parts = selectedItem.Split('|').Select(p => p.Trim()).ToArray();

                if(parts.Length  == 3)
                {
                    TBEmpID.Text = parts[0];
                    TBEmpName.Text = parts[1];
                    TBEmpAge.Text = parts[2];
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
