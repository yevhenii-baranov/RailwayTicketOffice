using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RailwayTicketOffice.Entity
{
    [Table("trip")]
    public class Trip : Entity
    {
        [Required] public int TrainId { get; set; }
        [Required] public Train Train { get; set; }

        [Required] public DateTime TripDate { get; set; }
    }
}
