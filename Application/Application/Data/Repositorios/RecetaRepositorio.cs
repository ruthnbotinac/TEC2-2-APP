using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositorios
{
    public class RecetaRepositorio : IRepositorio<Receta>
    {
        private const string COLLECTION_NAME = "receta";
        private readonly Conexion _conexion;

        public RecetaRepositorio(Conexion dbConnection)
        {
            _conexion = dbConnection;
        }
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Receta> FindAll()
        {
            throw new NotImplementedException();
        }

        public Receta FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Receta entity)
        {
            throw new NotImplementedException();
        }

        public Receta update(Receta entity)
        {
            throw new NotImplementedException();
        }

        private FireStoreModels.Receta MapEntityToFirestoreModel(Receta entity)
        {
            return new FireStoreModels.Receta
            {
                Id = entity.Id,
                NombreReceta = entity.NombreReceta,
                Raciones = entity.Raciones,
                Descripcion = entity.Descripcion,
            };
        }

        private Receta MapFirebaseModelToEntity(FireStoreModels.Receta model)
        {
            return new Receta(model.Id, model.NombreReceta, model.Raciones, model.Descripcion);
        }
    }
}
