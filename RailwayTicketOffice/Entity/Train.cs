using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("train")]
    public class Train : Entity
    {
        [Required] public DateTime DepartureDate { get; set; }

        [Required] public DateTime ArrivalTime { get; set; }

        [Required] public ICollection<TrainCarriage> TrainCarriages { get; set; }

        [Required] public TrainStation DepartureStation { get; set; }

        [Required] public TrainStation ArrivalStation { get; set; }
    }
}