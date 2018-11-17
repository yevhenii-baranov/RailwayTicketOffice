using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Entity
{
    public class Carriage
    {
        public enum CarriageType
        {
            Sitting,
            Common,
            Couchette,
            Compartment,
            Deluxe
        }

        public int CarriageID { get; set; }
        
        [Required]
        public CarriageType Type { get; set; }
        
        [Required]
        public List<CarriageSeat> Seats = new List<CarriageSeat>();
    }
}