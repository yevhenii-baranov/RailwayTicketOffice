namespace RailwayTicketOffice.Entity
{
    public class Ticket
    {
        public enum TicketType
        {
            Full,
            Student,
            Child
        }

        public int TicketId { get; set; }
        public Customer Customer { get; set; }
        public Train Train { get; set; }
        public CarriageSeat Seat { get; set; }
        public TicketType Type { get; set; }
        public decimal Price { get; set; }
    }
}