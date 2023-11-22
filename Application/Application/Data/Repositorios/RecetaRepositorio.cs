using Application.Utils;
using Google.Cloud.Firestore;
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

        public List<Receta> FindAll()
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindAll...");

                Query query = _conexion.FirestoreDb.Collection(COLLECTION_NAME);
                var querySnapshot = query.GetSnapshotAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                var list = new List<Receta>();
                foreach (var documentSnapshot in querySnapshot.Documents)
                {
                    if (!documentSnapshot.Exists) continue;
                    var data = documentSnapshot.ConvertTo<FireStoreModels.Receta>();
                    if (data == null) continue;
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

        public Receta FindById(string id)
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindById...{id}");

                var docRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME).Document(id);
                var snapshot = docRef.GetSnapshotAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                if (snapshot.Exists)
                {
                    var recetaModel = snapshot.ConvertTo<FireStoreModels.Receta>();
                    recetaModel.Id = snapshot.Id;
                    MessageLogger.LogInformationMessage($"Success FindById...{id}");
                    return MapFirebaseModelToEntity(recetaModel);
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

        public void Insert(Receta entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"Insert...{entity.NombreReceta}");

                var fbModel = MapEntityToFirestoreModel(entity);
                var colRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME);
                var doc = colRef.AddAsync(fbModel).ConfigureAwait(false).GetAwaiter().GetResult();


                MessageLogger.LogInformationMessage($"Success Insert...{entity.NombreReceta}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public Receta update(Receta entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"update...{entity.NombreReceta}");

                var recordRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME).Document(entity.Id);
                var fbModel = MapEntityToFirestoreModel(entity);
                recordRef.SetAsync(fbModel, SetOptions.MergeAll).ConfigureAwait(false).GetAwaiter().GetResult();
                MessageLogger.LogInformationMessage($"Success update...{entity.NombreReceta}");
                return entity;

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        private FireStoreModels.Receta MapEntityToFirestoreModel(Receta entity)
        {
            return new FireStoreModels.Receta
            {
                Id = entity.Id,
                NombreReceta = entity.NombreReceta,
                Raciones = entity.Raciones.Select(x=> new FireStoreModels.Racion { Id = x.Id, Peso = x.Peso, Producto = x.Producto, UnidadMedida = x.UnidadMedida}).ToList(),
                Descripcion = entity.Descripcion,
            };
        }

        private Receta MapFirebaseModelToEntity(FireStoreModels.Receta model)
        {
            return new Receta
            {
                Id = model.Id,
                NombreReceta = model.NombreReceta,
                Raciones = model.Raciones.Select(x => new Racion { Id = x.Id, Peso = x.Peso, Producto = x.Producto, UnidadMedida = x.UnidadMedida }).ToList(),
                Descripcion = model.Descripcion
            };
        }
    }
}
