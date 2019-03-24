using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RailwayTicketOffice.Service
{
    class AuthenticationService
    {
        public User Authenticate(string username, string password)
        {
            using (var context = new MySqlDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    return user;
                }
                throw new CannotAuthenticateUser(username, password);
            }
        }

        internal void Register(string firstName, string lastName, string login, string password)
        {
            try
            {
                User user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Username = login,
                    Password = password,
                    UserRole = User.Role.USER
                };
                using (var context = new MySqlDbContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                throw new CannotRegisterUserException(ex);
            }
        }
    }

    public class CannotRegisterUserException : Exception
    {
        private readonly DbUpdateException ex;

        public CannotRegisterUserException(DbUpdateException ex)
        {
            this.ex = ex;
        }

        public Exception GetCause()
        {
            return ex;
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
