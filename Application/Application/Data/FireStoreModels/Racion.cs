using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.FireStoreModels
{
    [FirestoreData]
    public class Racion
    {
        [FirestoreDocumentId]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Producto { get; set; }
        [FirestoreProperty]
        public double Peso { get; set; }
        [FirestoreProperty]
        public string UnidadMedida { get; set; }
    }
}
