using Microsoft.EntityFrameworkCore;

namespace RailwayTicketOffice.DAO.MySQL
{
    public abstract class MySqlDao<T> : IGenericDao<T> where T : class
    {
        public abstract int Add(T entity);
        public abstract T FindById(int id);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
    }
}