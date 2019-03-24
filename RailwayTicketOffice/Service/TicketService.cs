using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RailwayTicketOffice.Service
{
    internal class TicketService
    {
        public List<Ticket> GetTickets(User user)
        {
            using(var context = new MySqlDbContext())
            {
                var tickets = context.Tickets
                    .Include(ticket => ticket.Passenger)
                    .Where(ticket => ticket.Passenger.ID == user.ID)
                    .Include(ticket => ticket.Seat)
                    .ThenInclude(seat => seat.Carriage)
                    .Include(ticket => ticket.Train)
                    .ThenInclude(train => train.DepartureStation)
                    .Include(ticket => ticket.Train)
                    .ThenInclude(ticket => ticket.ArrivalStation)
                    .Include(ticket => ticket.Train)
                    .ToList();
                return tickets;
            }

        }
    }
}