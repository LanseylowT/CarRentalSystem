using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Common;
using CarRentalSystem.Handlers.CommandHandlers;
using CarRentalSystem.Handlers.QueryHandlers;

namespace CarRentalSystem.TestViews
{
    public partial class TestLogin : Form
    {
        private UserAccountQueryHandler _accountQueryHandler;

        public TestLogin()
        {
            InitializeComponent();
            _accountQueryHandler = new UserAccountQueryHandler(Commons.ConnectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if all fields are not empty
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowErrorMessage("Username must not be empty!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowErrorMessage("Password must not be empty!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowErrorMessage("Please Enter username and password!");
                return;
            }


            // Remove the error message if there is none
            lblErrorMessage.Visible = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_accountQueryHandler.VerifyLogin(username, password))
            {
                MessageBox.Show("Login Successfully!");
            }
            else
            {
                MessageBox.Show("Username and Password does not match!");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Helper functions
        private void ShowErrorMessage(string message)
        {
            lblErrorMessage.Visible = true;
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Text = message;
        }
    }
}