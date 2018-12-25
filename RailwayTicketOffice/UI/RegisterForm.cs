using RailwayTicketOffice.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayTicketOffice
{
    public partial class RegisterForm : Form
    {
        private readonly AuthenticationService authenticationService = TicketOfficeApplication.GetInstance().GetAuthenticationService();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!PerformValidation()) return;
            try
            {
                string firstName = FirstNameBox.Text;
                string lastName = LastNameBox.Text;
                string login = LoginBox.Text;
                string password = PasswordBox.Text;

                authenticationService.Register(firstName, lastName, login, password);

                MessageBox.Show("Success!");
            }
            catch (CannotRegisterUserException ex)
            {
                MessageBox.Show("Cannot register user, perhaps user with such login already exists?");
            }
        }

        private bool PerformValidation()
        {
            if (FirstNameBox.Text == "" || LastNameBox.Text == "" || LoginBox.Text == ""
                || PasswordBox.Text == "" || RepeatPasswordBox.Text == "")
            {
                MessageBox.Show("All fields must be filled!");
                return false;
            }
            else if (!PasswordBox.Text.Equals(RepeatPasswordBox.Text))
            {
                MessageBox.Show("Passwords do not match!");
                return false;
            }
            return true;
        }
    }
}
