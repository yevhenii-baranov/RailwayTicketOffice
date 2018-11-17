using System.Collections.Generic;

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

        public int CarriageId { get; set; }
        public CarriageType Type { get; set; }
        public List<CarriageSeat> Seats = new List<CarriageSeat>();
    }
}