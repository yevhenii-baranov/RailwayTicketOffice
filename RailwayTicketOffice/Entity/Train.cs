using System;
using System.Collections.Generic;

namespace RailwayTicketOffice.Entity
{
    public class Train
    {
        public int TrainId { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalTime { get; set; }
        public List<Carriage> Carriages = new List<Carriage>();
        public TrainStation DepartureStation { get; set; }
        public TrainStation ArrivalStation { get; set; }
    }
}