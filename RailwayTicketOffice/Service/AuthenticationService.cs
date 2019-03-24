using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;

namespace RailwayTicketOffice.Service
{
    internal class AuthenticationService
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
                var user = new User
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
        private readonly DbUpdateException _ex;

        public CannotRegisterUserException(DbUpdateException ex)
        {
            this._ex = ex;
        }

        public Exception GetCause()
        {
            return _ex;
        }
    }

    public class CannotAuthenticateUser : Exception
    {
        public CannotAuthenticateUser(string username, string password)
            : base($"There is no user with user name {username} and password {password}")
        {
        }
    };
}