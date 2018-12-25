﻿using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

                else if (departureDate != null) {
                    trips = RecursiveLoadTrip(
                        context.Trips.Where( 
                           trip => trip.TripDate.Equals(departureDate)));
                }
                else if(departureStation != null && arrivalStation != null)
                {
                    trips = RecursiveLoadTrip(
                        context.Trips.Where(
                            trip => trip.Train.DepartureStation.Equals(departureStation)
                            && trip.Train.ArrivalStation.Equals(arrivalStation)));
                }
                else
                {
                    trips = RecursiveLoadTrip(context.Trips);
                }
            }
            return trips;
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
                .ThenInclude(train =>train.DepartureStation)
                .ToList();
        }
    }
}