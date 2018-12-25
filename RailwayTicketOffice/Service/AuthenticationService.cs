using RailwayTicketOffice.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayTicketOffice.Service
{
    class AuthenticationService
    {
        public User authenticate(string username, string password)
        {
            return null;
        }


    }
    public class CannotAuthenticateUser : Exception
    {
        public CannotAuthenticateUser(string username, string password)
            : base("There is no user with user name {0} and password {1}")
        {

        }
    };
}
