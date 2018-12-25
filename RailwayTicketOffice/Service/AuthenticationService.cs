using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayTicketOffice.Service
{
    class AuthenticationService
    {
        public User Authenticate(string username, string password)
        {
            using (var context = new MySqlDbContext()) {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    return user;
                }
                throw new CannotAuthenticateUser(username, password);
            }
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
