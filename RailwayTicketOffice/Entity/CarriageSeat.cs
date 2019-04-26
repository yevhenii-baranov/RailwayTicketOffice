using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("seat")]
    public class CarriageSeat : Entity
    {
        [Required] public int NumberInCarriage { get; set; }
        
        [Required] public Carriage Carriage { get; set; }

        public override string ToString()
        {
            return $"Seat #{NumberInCarriage}";
        }
    }
}