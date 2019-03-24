using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwayTicketOffice.Service
{
    public class TrainFindingService
    {

        public List<Trip> FindTrips(TrainStation departureStation, TrainStation arrivalStation, DateTime? departureDate)
        {
            List<Trip> trips = null;
            using (var context = new MySqlDbContext())
            {
                if (departureStation != null && arrivalStation != null && departureDate != null)
                {
                    trips = context.Trips.Where(
                        trip => trip.TripDate.Equals(departureDate)
                        && trip.Train.DepartureStation.Equals(departureStation)
                        && trip.Train.ArrivalStation.Equals(arrivalStation)).ToList();
                }

                else if (departureDate != null)
                {
                    trips = RecursiveLoadTrip(
                        context.Trips.Where(
                           trip => trip.TripDate.Equals(departureDate)));
                }
                else if (departureStation != null && arrivalStation != null)
                {
                    trips = RecursiveLoadTrip(
                                context.Trips.Where(
                            trip => trip.Train.DepartureStation.Equals(departureStation)
                            && trip.Train.ArrivalStation.Equals(arrivalStation)
                            ));
                }
                else
                {
                    trips = RecursiveLoadTrip(context.Trips);
                }
            }
            return trips;
        }

        public void BuyTicket(Trip trip, CarriageSeat currentSeat, User currentUser)
        {
            decimal price = 100 + Convert.ToInt32(currentSeat.Carriage.CarriageType) * 25;
            using (var context = new MySqlDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.ID == currentUser.ID);
                Ticket ticket = new Ticket { Passenger = user,
                    Price = price,
                    SeatId = currentSeat.ID,
                    TicketType = TicketType.Full,
                    Train = trip.Train,
                    Date = trip.TripDate};
                context.Tickets.Update(ticket);
                context.SaveChanges();
            }
        }

        public List<CarriageSeat> GetAvailableSeats(Carriage carriage, Trip trip)
        {
            using (var context = new MySqlDbContext())
            {
                List<CarriageSeat> seats = context.Seats.Include(seat => seat.Carriage)
                    .Where(seat => seat.Carriage == carriage).ToList();

                var tickets = from t in context.Tickets where t.Seat.Carriage.Equals(carriage) select t;

                foreach (var ticket in tickets)
                {
                    seats.Remove(ticket.Seat);
                }

                return seats;
            }
        }

        public static TrainStation StationForName(string stationName)
        {
            using (var context = new MySqlDbContext())
            {
                return context.Stations.FirstOrDefault(station => station.Name == stationName);
            }
        }

        private static List<Trip> RecursiveLoadTrip(IQueryable<Trip> set)
        {
            return set.Include(trip => trip.Train)
                .ThenInclude(train => train.ArrivalStation)
                .Include(trip => trip.Train)
                .ThenInclude(train => train.DepartureStation)
                .ToList();
        }

        public List<Carriage> GetCarriagesForTrain(Train train)
        {
            using (var context = new MySqlDbContext())
            {
                var tc = context.TrainCarriages.Where(trainCarriage => trainCarriage.TrainID == train.ID)
                    .Include(trainCarriage => trainCarriage.Carriage);
                List<Carriage> carriages = new List<Carriage>();

                foreach (var tcar in tc)
                {
                    carriages.Add(tcar.Carriage);
                }
                return carriages;
            }
        }
    }
}
