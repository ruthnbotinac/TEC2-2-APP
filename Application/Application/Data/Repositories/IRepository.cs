namespace CódigoFiguras.Data.Repositories
{
    public interface IRepository<T>
    {
        T FindById(string id);
        List<T> FindAll();

        void Insert(T entity);

        T Update(T entity);
        void Delete(string id);
    }
}
