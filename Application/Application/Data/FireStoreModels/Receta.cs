using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.FireStoreModels
{
    [FirestoreData]
    public class Receta
    {
        [FirestoreDocumentId]
        public string Id { get; set; }
        [FirestoreProperty]
        public List<Application.Data.FireStoreModels.Racion> Raciones { get; set; }
        [FirestoreProperty]
        public Dictionary<int, string> Descripcion { get; set; }
        [FirestoreProperty]
        public string NombreReceta { get; set; }

        
    }
}
