using System.Collections.Generic;
using RailwayTicketOffice.Entity;

namespace RailwayTicketOffice.Models
{
    public class AvailableSeatsModel
    {
        
        public int TripId { get; set; }
        
        public IEnumerable<CarriageModel> Carriages { get; set; }
    }
} 

public class SeatModel
{
    public int SeatId { get; set; }
    public int CarriageId { get; set; }
            
    public int NumberInCarriage { get; set; }    
}

public class CarriageModel
{
    public int Id { get; set; }
    
    public IEnumerable<SeatModel> Seats { get; set; }
    
    public CarriageType Type { get; set; }
    
    public decimal Price { get; set; }
}