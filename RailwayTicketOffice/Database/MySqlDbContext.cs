using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Entity;

namespace RailwayTicketOffice.Database
{
    public sealed class MySqlDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=railway;user=root;password=dotnetframework");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(passenger => passenger.PassportData).IsUnique();

            modelBuilder.Entity<TrainCarriage>()
                .HasKey(t => new {t.CarriageID, t.TrainID});

            modelBuilder.Entity<TrainCarriage>()
                .HasOne(tc => tc.Train)
                .WithMany(train => train.TrainCarriages)
                .HasForeignKey(tc => tc.TrainID);

            modelBuilder.Entity<TrainCarriage>()
                .HasOne(tc => tc.Carriage)
                .WithMany(car => car.TrainCarriages)
                .HasForeignKey(tc => tc.CarriageID);

            modelBuilder.Entity<CarriageSeat>()
                .Property(seat => seat.Ordered)
                .HasColumnType("bit")
                .HasDefaultValue(false);
        }

        public DbSet<TrainStation> Stations { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Carriage> Carriages { get; set; }
        public DbSet<CarriageSeat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}