using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Entity
{
    public class CarriageSeat
    {
        public int CarriageSeatID { get; set; }
        
        [Required]
        public int NumberInCarriage { get; set; }
        
        [Required]
        public bool Ordered { get; set; }
    }
}