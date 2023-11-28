using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.FirestoreModels
{
    [FirestoreData]
    public class solicitante
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

    }
}
