using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data
{
    public class Conexion
    {
        public FirestoreDb FirestoreDb { get; set; }

        public Conexion()
        {
            var filePath = @"C:\Users\user\Documents\GitHub\TEC2-2-APP\Application\Application\Data\inventariococina-9e354-firebase-adminsdk-vhy8w-b78800f0f2.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);
            FirestoreDb = FirestoreDb.Create("inventariococina-9e354");

        }
    }
}
