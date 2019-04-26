using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Models
{
    public class OrderModel
    {
        [DisplayName("Order identifier")]
        public int TicketId { get; set; }
        
        [DisplayName("From")]
        public string DepartureStation { get; set; }

        [DisplayName("To")]
        public string ArrivalStation { get; set; }

        public decimal Price { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]        
        [DisplayName("Date of the trip")]
        public DateTime TripDate { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]        
        [DisplayName("Date of the purchase")]
        public DateTime PurchaseDate { get; set; }
    }
}