using Application.Utils;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositorios
{
    public class InventarioRepositorio : IRepositorio<Inventario>
    {
        private const string COLLECTION_NAME = "inventario";
        private readonly Conexion _conexion;

        public InventarioRepositorio(Conexion dbConnection)
        {
            _conexion = dbConnection;
        }

        public void Delete(string id)
        {
            try
            {
                MessageLogger.LogWarringMessage($"Deleting...{id}");

                var recordRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME).Document(id);
                recordRef.DeleteAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                MessageLogger.LogInformationMessage($"Success Delete...{id}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public List<Inventario> FindAll()
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindAll...");

                Query query = _conexion.FirestoreDb.Collection(COLLECTION_NAME);
                var querySnapshot = query.GetSnapshotAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                var list = new List<Inventario>();
                foreach (var documentSnapshot in querySnapshot.Documents)
                {
                    if (!documentSnapshot.Exists) continue;
                    var data = documentSnapshot.ConvertTo<FireStoreModels.Inventario>();
                    if (data == null) continue;
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

        public Inventario FindById(string id)
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindById...{id}");

                var docRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME).Document(id);
                var snapshot = docRef.GetSnapshotAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                if (snapshot.Exists)
                {
                    var inventarioModel = snapshot.ConvertTo<FireStoreModels.Inventario>();
                    inventarioModel.Id = snapshot.Id;
                    MessageLogger.LogInformationMessage($"Success FindById...{id}");
                    return MapFirebaseModelToEntity(inventarioModel);

                }
                MessageLogger.LogWarringMessage($"Collection class dosen't exsit");
                return null;

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public void Insert(Inventario entity)
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

        public Inventario update(Inventario entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"update...{entity.Producto}");

                var recordRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME).Document(entity.Id);
                var fbModel = MapEntityToFirestoreModel(entity);
                recordRef.SetAsync(fbModel, SetOptions.MergeAll).ConfigureAwait(false).GetAwaiter().GetResult();
                MessageLogger.LogInformationMessage($"Success update...{entity.Producto}");
                return entity;

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        private FireStoreModels.Inventario MapEntityToFirestoreModel(Inventario entity)
        {
            return new FireStoreModels.Inventario
            {
                Id = entity.Id,
                Peso = entity.Peso,
                Producto = entity.Producto,
                UnidadMedida = entity.UnidadMedida,
            };
        }

        private Inventario MapFirebaseModelToEntity(FireStoreModels.Inventario model)
        {
            return new Inventario(model.Id, model.Producto, model.Peso, model.UnidadMedida);
        }
    }
}
