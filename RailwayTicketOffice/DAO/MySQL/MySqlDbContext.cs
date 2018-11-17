using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Entity;

namespace RailwayTicketOffice.DAO.MySQL
{
    public sealed class MySqlDbContext: DbContext
    {
        public MySqlDbContext(): base()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=railway;user=root;password=Philosophy2018");
        }

        public DbSet<TrainStation> Stations { get; set; }
      //  public DbSet<Train> Trains { get; set; }
      //  public DbSet<Carriage> Carriages { get; set; }
    }
}