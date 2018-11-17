using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Entity;

namespace RailwayTicketOffice.DbContext
{
    public sealed class MySqlDbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=railway;user=root;password=Philosophy2018");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passenger>().HasIndex(passenger => passenger.PassportData).IsUnique();
        }

        public DbSet<TrainStation> Stations { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Carriage> Carriages { get; set; }
        public DbSet<CarriageSeat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
    }
}