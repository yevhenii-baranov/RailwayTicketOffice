using System.Linq;
using RailwayTicketOffice.Entity;

namespace RailwayTicketOffice.DAO.MySQL
{
    public class MySqlTrainStationDao : MySqlDao<TrainStation>
    {
        public override int Add(TrainStation entity)
        {
            using (var context = new MySqlDbContext())
            {
                context.Stations.Add(entity);
                context.SaveChanges();
                return 0;
            }
        }

        public override TrainStation FindById(int id)
        {
            using (var context = new MySqlDbContext())
            {
                return context.Stations.Find(id);
            }
        }

        public override void Update(TrainStation entity)
        {
            throw new System.NotImplementedException();
        }

        public override void Delete(TrainStation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}