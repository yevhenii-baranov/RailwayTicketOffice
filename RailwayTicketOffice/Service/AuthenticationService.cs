using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;

namespace RailwayTicketOffice.Service
{
    internal class AuthenticationService
    {
        private readonly ILogger _logger = new LoggerFactory().CreateLogger(typeof(AuthenticationService));
        
        public async Task Authenticate(string email, string password, HttpContext httpContext)
        {
            using (var context = new MySqlDbContext())
            {
                var user = await context.Users
                    .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);

                if (user != null)
                {

                    // Creating claim
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                        new Claim(ClaimsIdentity.DefaultRoleClaimType, user.UserRole.ToString())
                    };
                    
                    var role = user.UserRole.ToString();
                    
                    // Creating Claim Identity
                    var id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                        ClaimsIdentity.DefaultRoleClaimType);

                    // Setting up authentication cookies
                    await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(id));
                }
                else throw new CannotAuthenticateUser(email, password);
            }
        }

        internal void Register(string email, string password)
        {
            try
            {
                var user = new User
                {
                    Email = email,
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

        public async Task LogOut(HttpContext context)
        {
            await context.SignOutAsync();
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