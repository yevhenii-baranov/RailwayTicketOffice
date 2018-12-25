using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("trainCarriage")]
    public class TrainCarriage
    {
        [Required] public Train Train { get; set; }
        [Required] public int TrainID { get; set; }

        [Required] public Carriage Carriage { get; set; }
        [Required] public int CarriageID { get; set; }
    }
}