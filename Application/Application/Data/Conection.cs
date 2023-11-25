using Google.Cloud.Firestore;

namespace CódigoFiguras.Data
{
    public class Conection
    {
        public FirestoreDb FirestoreDb { get; set; }

        public Conection()
        {
            var filePath = @"Data\schoolexample-bc045-firebase-adminsdk-kgx5e-f8d4604364.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);
            FirestoreDb = FirestoreDb.Create("schoolexample-bc045");
        }
    }
}
