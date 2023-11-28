using Google.Cloud.Firestore;

namespace Application.Data
{
    public class Connection
    {
        public FirestoreDb FirestoreDb { get; set; }

        public Connection()
        {
            var filePath = @"Data\sgicompras-e1064-firebase-adminsdk-sr8sa-1447f3d489";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);
            FirestoreDb = FirestoreDb.Create("sgicompras-e1064");


        }
    }
}
