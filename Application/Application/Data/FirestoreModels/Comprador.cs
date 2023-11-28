using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.FirestoreModels
{
    [FirestoreData]
    public class Comprador
    {
        [FirestoreDocumentId]
        public string Nombre { get; set; }
        [FirestoreProperty]
        public int CodigoComprador { get; set; }
        [FirestoreProperty]
    }
}
