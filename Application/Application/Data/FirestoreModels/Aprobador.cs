using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.FirestoreModels
{
    [FirestoreData]
    public class Aprobador
    {
        [FirestoreDocumentId]
        public string Id { get; set; }
        [FirestoreProperty]
        public int codigoAprobador { get; set; }
        [FirestoreProperty]
        public string NombreAprobador { get; set; }
        [FirestoreProperty]
        public string Departamento { get; set; }
     

    }
}
