using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RailwayTicketOffice.Entity;

namespace RailwayTicketOffice.Models
{
    public class TripModel
    {
        public int ID { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]        
        [DisplayName("Date of the trip")]
        public DateTime TripDate { get; set; }
        
        [DisplayFormat(DataFormatString="{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DisplayName("Arrival time")]
        public TimeSpan ArrivalTime { get; set; }

        [DisplayFormat(DataFormatString="{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DisplayName("Departure time")]
        public TimeSpan DepartureTime { get; set; }

        [DisplayName("From")]
        public string DepartureStation { get; set; }

        [DisplayName("To")]
        public string ArrivalStation { get; set; }
    }
}