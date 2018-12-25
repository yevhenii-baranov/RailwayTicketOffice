using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;
using RailwayTicketOffice.Service;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RailwayTicketOffice
{
    class TicketOfficeApplication
    {
        private static TicketOfficeApplication application = null;

        private readonly AuthenticationService authService = new AuthenticationService();
        public User CurrentUser { get; set; }

        private TicketOfficeApplication()
        {
            using(var context = new MySqlDbContext())
            {
                if (!context.Database.EnsureCreated())
                {
                    context.Database.Migrate();
                }
            }
        }

        public AuthenticationService GetAuthenticationService()
        {
            return authService;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static TicketOfficeApplication GetInstance()
        {
            if(application == null)
            {
                application = new TicketOfficeApplication();
            }
            return application;
        }
    }
}
