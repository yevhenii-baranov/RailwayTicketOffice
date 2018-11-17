using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Entity
{
    public class Passenger
    {
        public int PassengerID { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string PassportData { get; set; }
    }
}