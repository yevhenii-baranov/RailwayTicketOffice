using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RailwayTicketOffice.Models;
using RailwayTicketOffice.Service;

namespace RailwayTicketOffice.Controllers
{
    public class BuyTicketController : Controller
    {
        private readonly TrainFindingService _trainFindingService = new TrainFindingService();
        private readonly UserManagementService _userManagementService = new UserManagementService();
        
        public IActionResult Buy(int tripId)
        {
            var models = new List<CarriageModel>();

            var trip = _trainFindingService.GetTripById(tripId);
            var carriages = _trainFindingService.GetCarriagesForTrain(trip.Train);

            foreach (var carriage in carriages)
            {
                var seats = _trainFindingService.GetAvailableSeats(carriage, trip);

                var seatModels = seats.Select(seat => new SeatModel()
                {
                    SeatId = seat.ID,
                    CarriageId = seat.Carriage.ID,
                    NumberInCarriage = seat.NumberInCarriage
                });


                var model = new CarriageModel
                {
                    Id = carriage.ID,
                    Price = TrainFindingService.GetPrice(carriage.CarriageType),
                    Seats = seatModels,
                    Type = carriage.CarriageType
                };

                models.Add(model);
            }

            return View(new AvailableSeatsModel
            {
                Carriages = models,
                TripId = trip.ID
            });
        }

        [HttpPost]
        public IActionResult Buy(int tripId, int seatId, string userEmail)
        {
            var currentUser = _userManagementService.FindByEmail(userEmail);

          /*  if (currentUser.PassportData == null || currentUser.FirstName == null || currentUser.LastName == null)
            {
                return ();
            }*/
            
            
            var trip = _trainFindingService.GetTripById(tripId);
            var seat = _trainFindingService.GetSeatById(seatId);
            
            _trainFindingService.BuyTicket(trip, seat, currentUser);

            return RedirectToAction("PurchaseSuccessful");
        }

        public IActionResult PurchaseSuccessful()
        {
            return View();
        }
    }
}