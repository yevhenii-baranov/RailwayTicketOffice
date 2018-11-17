using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("ticket")]
    public class Ticket : Entity
    {
        public enum TicketType
        {
            Full,
            Student,
            Child
        }

        [Required] public Passenger Passenger { get; set; }

        [Required] public Train Train { get; set; }

        [Required] public CarriageSeat Seat { get; set; }

        [Required] public TicketType Type { get; set; }

        [Required] public decimal Price { get; set; }
    }
}