using Application.Utils;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositorios
{
    public class UsuarioRepositorio : IRepositorio<Usuario>
    {
        private const string COLLECTION_NAME = "usuario";
        private readonly Conexion _conexion;

        public UsuarioRepositorio(Conexion dbConnection)
        {
            _conexion = dbConnection;
        }

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

        public Usuario update(Usuario entity)
        {
            throw new NotImplementedException();
        }


        private FireStoreModels.Usuario MapEntityToFirestoreModel(Usuario entity)
        {
            return new FireStoreModels.Usuario
            {
                Id = entity.Id,
                userName = entity.UserName,
                Password = entity.Password,
            };
        }

        private Usuario MapFirebaseModelToEntity(FireStoreModels.Usuario model)
        {
            return new Usuario(model.Id, model.userName, model.Password);
        }

    }
}
