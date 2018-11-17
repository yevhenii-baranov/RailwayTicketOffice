using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("carriage")]
    public class Carriage : Entity
    {
        public enum CarriageType
        {
            Sitting,
            Common,
            Couchette,
            Compartment,
            Deluxe
        }

        [Required] public CarriageType Type { get; set; }

        [Required] public List<CarriageSeat> Seats = new List<CarriageSeat>();
    }
}