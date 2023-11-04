using Application.Data.FireStoreModels;
using Application.Utils;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositorios
{
    public class RacionRepositorio : IRepositorio<FireStoreModels.Racion>
    {
        private const string COLLECTION_NAME = "class";
        private readonly Conexion _conexion;
public void Delete(string id)
        {
            try
            {
                MessageLogger.LogInformationMessage($"Deleting...{id}");

                MessageLogger.LogInformationMessage($"Success Delete...{id}");

            }
            catch (Exception ex) 
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public List<FireStoreModels.Racion> FindAll()
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindAll...");

                MessageLogger.LogInformationMessage($"Success FindAll");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public void FindById(string id)
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindById...{id}");

                MessageLogger.LogInformationMessage($"Success FindById...{id}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public void Insert(FireStoreModels.Racion entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"Insert...{entity.Producto}");

                MessageLogger.LogInformationMessage($"Success Insert...{entity.Producto}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public FireStoreModels.Racion update(FireStoreModels.Racion entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"update...{entity.Producto}");

                MessageLogger.LogInformationMessage($"Success update...{entity.Producto}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        private FireStoreModels.Racion MapEntityToFireStoreModel(Racion entity) 
        {
            return new FireStoreModels.Racion
            {
                Id = entity.Id,
                Peso = entity.Peso,
                Producto = entity.Producto,
            };
        }

        private Racion FirebaseModelToEntity(FireStoreModels.Racion model) 
        {
            return new Racion(model.Id, model.Producto, model.Peso);
        }

    }
}
