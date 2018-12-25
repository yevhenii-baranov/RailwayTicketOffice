using RailwayTicketOffice.Service;
using System;

namespace RailwayTicketOffice
{
    public partial class LoginForm
    {
        private readonly AuthenticationService authService = TicketOfficeApplication.GetInstance().GetAuthenticationService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;

            try
            {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Text;

                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";

                var user = authService.Authenticate(username, password);
                TicketOfficeApplication.GetInstance().CurrentUser = user;

                Schedule scheduleForm = new Schedule(this);
                scheduleForm.Show();
                this.Hide();
            }
            catch (CannotAuthenticateUser ex)
            {
                ErrorLabel.Visible = true;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
