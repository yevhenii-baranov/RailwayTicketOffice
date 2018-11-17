using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Entity
{
    public class Train
    {
        public int TrainID { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }
        
        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        public List<Carriage> Carriages = new List<Carriage>();

        [Required]
        public TrainStation DepartureStation { get; set; }
        
        [Required]
        public TrainStation ArrivalStation { get; set; }
    }
}