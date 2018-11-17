namespace RailwayTicketOffice.DAO
{
    interface IGenericDao<T>
    {
        int Add(T entity);

        T FindById(int id);

        void Update(T entity);

        void Delete(T entity);
    }
}