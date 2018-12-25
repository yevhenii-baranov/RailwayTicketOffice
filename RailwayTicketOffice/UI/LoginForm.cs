﻿using RailwayTicketOffice.Service;
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

                var user = authService.Authenticate(username, password);
                TicketOfficeApplication.GetInstance().CurrentUser = user;
            }
            catch (CannotAuthenticateUser ex)
            {
                ErrorLabel.Visible = true;
                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
            }
        }

    }
}
