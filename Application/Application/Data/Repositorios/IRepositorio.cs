using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositorios
{
    public interface IRepositorio<T>
    {
        T FindById(string  id);

        public List<T> FindAll();

        void Insert(T entity);

        T update(T entity);

        void Delete(string id);
    }
}
