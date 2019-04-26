using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RailwayTicketOffice.Models;
using RailwayTicketOffice.Service;

namespace RailwayTicketOffice.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly TrainFindingService _trainFindingService = new TrainFindingService();
        private readonly TicketService _ticketService = new TicketService();
        private readonly UserManagementService _userManagementService = new UserManagementService();
        
        public IActionResult Index()
        {
            var trips = _trainFindingService.FindTrips(null, null, null);
            var tripModels = trips.Select(trip => new TripModel
            {
                ID = trip.ID,
                TripDate = trip.TripDate,
                ArrivalStation = trip.Train.ArrivalStation.Name,
                DepartureStation = trip.Train.DepartureStation.Name,
                ArrivalTime = trip.Train.ArrivalTime,
                DepartureTime = trip.Train.DepartureTime
            });
            return View(tripModels);
        }

        public IActionResult Orders()
        {
            var email = HttpContext.User.Identity.Name;
            var currentUser = _userManagementService.FindByEmail(email);
            var orderList = _ticketService.GetTickets(currentUser);

            var orders = new List<OrderModel>();
            foreach (var ticket in orderList)
            {
                var order = new OrderModel
                {
                };
                orders.Add(order);
            }

            return View(orders);
        }
    }
}