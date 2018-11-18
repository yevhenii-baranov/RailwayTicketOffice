using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("carriage")]
    public class Carriage : Entity
    {
        [Required] public CarriageType CarriageType { get; set; }

        public ICollection<TrainCarriage> TrainCarriages { get; set; }
    }

    public enum CarriageType : int
    {
        Sitting = 1,
        Common = 2,
        Couchette = 3,
        Compartment = 4,
        Deluxe = 5
    }
}