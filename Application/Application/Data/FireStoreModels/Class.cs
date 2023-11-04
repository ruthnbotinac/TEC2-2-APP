using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.FireStoreModels
{
    [FirestoreData]
    public class Class
    {
        public Class(int id, Class className)
        {
            Id = id;
            ClassName = className;
        }

        [FirestoreDocumentId]
        public int Id { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public Class ClassName { get; internal set; }
    }
}
