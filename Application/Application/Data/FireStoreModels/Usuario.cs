using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.FireStoreModels
{
    [FirestoreData]
    internal class Usuario
    {
        [FirestoreDocumentId]
        public string Id { get; set; }
        [FirestoreProperty]
        public string UserName { get; set; }
        [FirestoreProperty]
        public static string Password { get; set; }


    }
}
