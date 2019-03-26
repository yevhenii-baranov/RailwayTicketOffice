using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RailwayTicketOffice.Entity;
using RailwayTicketOffice.Models;
using RailwayTicketOffice.Service;

namespace RailwayTicketOffice.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly TrainFindingService _service = new TrainFindingService();
        
        public IActionResult Index()
        {
            var trips = _service.FindTrips(null, null, null);
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
            return View();
        }
    }
}