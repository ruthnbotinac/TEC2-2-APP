using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositorios
{
    internal class UsuarioRepositorio : IRepositorio<Usuario>
    {
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public FireStoreModels.Usuario update(FireStoreModels.Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Usuario update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
