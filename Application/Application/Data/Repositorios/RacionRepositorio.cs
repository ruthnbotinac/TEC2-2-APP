using Application.Data.FireStoreModels;
using Application.Utils;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositorios
{
    public class RacionRepositorio : IRepositorio<Racion>
    {
        private const string COLLECTION_NAME = "racion";
        private readonly Conexion _conexion;

        public RacionRepositorio(Conexion dbConnection)
        {
            _conexion = dbConnection;
        }
        public Racion FindById(string id)
        {
            throw new Exception();
            /*try
            {
                MessageLogger.LogInformationMessage($"FindById...{id}");

                MessageLogger.LogInformationMessage($"Success FindById...{id}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }*/
        }

        public List<Racion> FindAll()
        {
            
            try
            {
                MessageLogger.LogInformationMessage($"FindAll...");

                Query query = _conexion.FirestoreDb.Collection(COLLECTION_NAME);
                var querySnapshot = query.GetSnapshotAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                var list = new List<Racion>();
                foreach (var documentSnapshot in querySnapshot.Documents)
                {
                    if (!documentSnapshot.Exists) continue;
                    var data = documentSnapshot.ConvertTo<FireStoreModels.Racion>();
                    if(data == null) continue;
                    data.Id = documentSnapshot.Id;
                    list.Add(MapFirebaseModelToEntity(data));
                }
                MessageLogger.LogInformationMessage($"Success FindAll");
                return list;

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public void Insert(Racion entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"Insert...{entity.Producto}");

                var fbModel = MapEntityToFirestoreModel(entity);
                var colRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME);
                var doc = colRef.AddAsync(fbModel).ConfigureAwait(false).GetAwaiter().GetResult();


                MessageLogger.LogInformationMessage($"Success Insert...{entity.Producto}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public Racion update(Racion entity)
        {
            throw new Exception();
            /*try
            {
                MessageLogger.LogInformationMessage($"update...{entity.Producto}");

                MessageLogger.LogInformationMessage($"Success update...{entity.Producto}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }*/
        }

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

        private FireStoreModels.Racion MapEntityToFirestoreModel(Racion entity) 
        {
            return new FireStoreModels.Racion
            {
                Id = entity.Id,
                Peso = entity.Peso,
                Producto = entity.Producto,
            };
        }

        private Racion MapFirebaseModelToEntity(FireStoreModels.Racion model) 
        {
            return new Racion(model.Id, model.Producto, model.Peso);
        }

    }
}
