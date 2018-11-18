using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Entity
{
    public class TrainCarriage
    {
        [Required] public Train Train { get; set; }
        [Required] public int TrainID { get; set; }

        [Required] public Carriage Carriage { get; set; }
        [Required] public int CarriageID { get; set; }
    }
}