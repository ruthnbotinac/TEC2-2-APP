using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositories
{
    public interface IRepository<T>
    {
        T FindByID(string id);
        List<T> FindAll();
        void Insert (T entity);
        T Update(T entity);

        void Delete (string id);
    }
}
