using Application.Utils;
using Google.Cloud.Firestore;
using IdeaBlade.EntityModel;
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

        public List<Usuario> FindAll()
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindAll...");

                Query query = _conexion.FirestoreDb.Collection(COLLECTION_NAME);
                var querySnapshot = query.GetSnapshotAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                var list = new List<Usuario>();
                foreach (var documentSnapshot in querySnapshot.Documents)
                {
                    if (!documentSnapshot.Exists) continue;
                    var data = documentSnapshot.ConvertTo<FireStoreModels.Usuario>();
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

        public Usuario FindById(string id)
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindById...{id}");

                var docRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME).Document(id);
                var snapshot = docRef.GetSnapshotAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                if (snapshot.Exists)
                {
                    var usuarioModel = snapshot.ConvertTo<FireStoreModels.Usuario>();
                    usuarioModel.Id = snapshot.Id;
                    MessageLogger.LogInformationMessage($"Success FindById...{id}");
                    return MapFirebaseModelToEntity(usuarioModel);
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

        public void Insert(Usuario entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"Insert...{entity.UserName}");

                var fbModel = MapEntityToFirestoreModel(entity);
                var colRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME);
                var doc = colRef.AddAsync(fbModel).ConfigureAwait(false).GetAwaiter().GetResult();


                MessageLogger.LogInformationMessage($"Success Insert...{entity.UserName}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public Usuario update(Usuario entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"update...{entity.Id}");

                var recordRef = _conexion.FirestoreDb.Collection(COLLECTION_NAME).Document(entity.Id);
                var fbModel = MapEntityToFirestoreModel(entity);
                recordRef.SetAsync(fbModel, SetOptions.MergeAll).ConfigureAwait(false).GetAwaiter().GetResult();
                MessageLogger.LogInformationMessage($"Success update...{entity.Id}");
                return entity;

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
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
