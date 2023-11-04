using Application.Data.FireStoreModels;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositorios
{
    public class ClassRepositorio : IRepositorio<Class>
    {
        private const string COLLECTION_NAME = "class";
        private readonly Conexion _conexion;
public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Class> FindAll()
        {
            throw new NotImplementedException();
        }

        public void FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Class entity)
        {
            throw new NotImplementedException();
        }

        public Class update(Class entity)
        {
            throw new NotImplementedException();
        }

        private FireStoreModels.Class MapEntityToFireStoreModel(Class entity) 
        {
            return new FireStoreModels.Class
            {
                Id = entity.Id,
                ClassName = entity.ClassName,
            };
        }

        private Class FirebaseModelToEntity(FireStoreModels.Class model) 
        {
            return new Class(model.Id, model.ClassName);
        }

    }
}
