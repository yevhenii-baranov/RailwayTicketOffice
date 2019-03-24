using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;
using System.Linq;

namespace RailwayTicketOffice.Service
{
    public class UserManagementService
{
    public User AddPassportData(User user, string passportData)
    {
        using (var context = new MySqlDbContext())
        {
            var userFromDb = context.Users.FirstOrDefault(u => u.ID == user.ID);
            userFromDb.PassportData = passportData;
            context.SaveChanges();
            return userFromDb;
        }
    }
}
}