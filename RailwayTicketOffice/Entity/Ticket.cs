using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Entity
{
    public class Ticket
    {
        public enum TicketType
        {
            Full,
            Student,
            Child
        }

        public int TicketID { get; set; }
        
        [Required]
        public Passenger Passenger { get; set; }
        
        [Required]
        public Train Train { get; set; }
        
        [Required]
        public CarriageSeat Seat { get; set; }
        
        [Required]
        public TicketType Type { get; set; }
        
        [Required]
        public decimal Price { get; set; }
    }
}