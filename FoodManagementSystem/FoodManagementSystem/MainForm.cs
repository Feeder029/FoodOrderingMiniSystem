namespace FoodManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            openChildForm(new Order());
            AddMouseEvents(BTNLogout, true);
            AddMouseEvents(BTNOrder);
            AddMouseEvents(BTNEmployee);
            AddMouseEvents(BTNPayment);
        }

        public Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new Order());

            SetActiveButtons(BTNOrder);
        }

        private void BTNEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new Employee());

            SetActiveButtons(BTNEmployee);
        }

        private void BTNPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new Payment());

            SetActiveButtons(BTNPayment);
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Hover
        private void AddMouseEvents(Label label, bool isLogout = false)
        {
            if (isLogout)
            {
                label.MouseEnter += (sender, e) => label.ForeColor = Color.Black;
                label.MouseLeave += (sender, e) => label.ForeColor = Color.Red;
            }
            else
            {
                label.MouseEnter += (sender, e) => label.BackColor = Color.SlateGray;
                label.MouseLeave += (sender, e) => label.BackColor = Color.Snow;
            }
        }

        //ActivePanel
        private void SetActiveButtons(Label activeButton)
        {
            BTNActiveOrder.Visible = activeButton == BTNOrder;
            BTNActiveEmployee.Visible = activeButton == BTNEmployee;
            BTNActivePayment.Visible = activeButton == BTNPayment;
        }
    }
}