using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositorios
{
    internal class UsuarioRepositorio : IRepositorio<FireStoreModels.Usuario>
    {
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<FireStoreModels.Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public void FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(FireStoreModels.Usuario entity)
        {
            throw new NotImplementedException();
        }

        public FireStoreModels.Usuario update(FireStoreModels.Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
