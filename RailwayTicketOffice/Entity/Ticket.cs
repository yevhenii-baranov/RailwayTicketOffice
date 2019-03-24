using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("ticket")]
    public class Ticket : Entity
    {
        [Required] public User Passenger { get; set; }

        [Required] public Train Train { get; set; }

        [Required] public int SeatId { get; set; }

        [Required] public CarriageSeat Seat { get; set; }

        [Required] public TicketType TicketType{ get; set; }

        [Required] public decimal Price { get; set; }

        [Required] public DateTime Date { get; set; }
    }
    
    public enum TicketType: int
    {
        Full = 1,
        Student = 2,
        Child = 3
    }
}