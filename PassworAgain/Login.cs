using System;
using System.Windows.Forms;

namespace PassworAgain
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if ((txtName.Text == "" && txtPass.Text == "" )|| (txtName.Text == "Matebe" && txtPass.Text == "ThisIsGreat"))
            {
                // Set DialogResult to OK to indicate successful login
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }
    }
}
