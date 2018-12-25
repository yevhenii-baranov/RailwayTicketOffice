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
        private readonly TrainFindingService trainFindingService = new TrainFindingService();


        public User CurrentUser { get; set; }

        private TicketOfficeApplication()
        {
        }

        public AuthenticationService GetAuthenticationService()
        {
            return authService;
        }

        public TrainFindingService GetTrainFindingService()
        {
            return trainFindingService;
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
