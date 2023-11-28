using Application.Utils;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositories
{


    public class AprobadorRepository : IRepository<Aprobador>
    {


        private const string COLLECTION_NAME = "aprobador";
        private readonly Connection _connection;
        public void Delete(string id)
        {
            try
            {
                MessageLogger.LogWarningMessage($"Deleting...{id}");

                var recordRef = _connection.FirestoreDb.Collection(COLLECTION_NAME).Document(id);
                recordRef.DeleteAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                MessageLogger.LogInformationMessage($"Success Delete...{id}");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }


        public List<Aprobador> FindAll()
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindAll...");

                Query query = _connection.FirestoreDb.Collection(COLLECTION_NAME);
                var querySnapshot = query.GetSnapshotAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                var list = new List<Aprobador>();
                foreach (var documentSnapshot in querySnapshot.Documents)
                {
                    if (!documentSnapshot.Exists) continue;
                    var data = documentSnapshot.ConvertTo<FirestoreModels.Aprobador>();
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

        public Aprobador FindByID(string id)
        {
            try
            {
                MessageLogger.LogInformationMessage($"FindById...{id}");

                var docRef = _connection.FirestoreDb.Collection(COLLECTION_NAME).Document(id);
                var snapshot = docRef.GetSnapshotAsync().ConfigureAwait(false).GetAwaiter().GetResult();

                if (snapshot.Exists)
                {
                    var aprobadorModel = snapshot.ConvertTo<FirestoreModels.Aprobador>();
                    aprobadorModel.Id = snapshot.Id;
                    MessageLogger.LogInformationMessage($"Success FindById...{id}");
                    return MapFirebaseModelToEntity(aprobadorModel);

                }
                MessageLogger.LogWarningMessage($"Collection class dosen't exsit");
                return null;

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public void Insert(Aprobador entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"Insert...{entity.nombreAprobador}");

                var fbModel = MapEntityToFirestoreModel(entity);
                var colRef = _connection.FirestoreDb.Collection(COLLECTION_NAME);
                var doc = colRef.AddAsync(fbModel).ConfigureAwait(false).GetAwaiter().GetResult();


                MessageLogger.LogInformationMessage($"Success Insert...{entity.nombreAprobador  }");

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }

        public Aprobador Update(Aprobador entity)
        {
            try
            {
                MessageLogger.LogInformationMessage($"update...{entity.nombreAprobador}");

                var recordRef = _connection.FirestoreDb.Collection(COLLECTION_NAME).Document(entity.Id);
                var fbModel = MapEntityToFirestoreModel(entity);
                recordRef.SetAsync(fbModel, SetOptions.MergeAll).ConfigureAwait(false).GetAwaiter().GetResult();
                MessageLogger.LogInformationMessage($"Success update...{entity.nombreAprobador}");
                return entity;

            }
            catch (Exception ex)
            {
                MessageLogger.LogErrorMessage(ex);
                throw;
            }
        }


        private FirestoreModels.Aprobador MapEntityToFirestoreModel(Aprobador entity)
        {
            return new FirestoreModels.Aprobador
            {
                Id = entity.Id,
                codigoAprobador = entity.CodigoAprobador,
                Departamento = entity.Departamento,
               
            };

        
        }
        private Aprobador MapFirebaseModelToEntity(FirestoreModels.Aprobador model)
        {
            return new Aprobador(model.Id, model.codigoAprobador, model.Departamento);
        }

    }
}
