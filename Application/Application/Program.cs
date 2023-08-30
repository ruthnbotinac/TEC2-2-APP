namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            User userProfile = new User();
            userProfile.firstnm = "Jose";
            userProfile.lastnm = "Cardenas";
            userProfile.eml = "cardenas123@best.com";
            userProfile.CustuserName = "JC Ortiz";
            userProfile.customerAge = 39;
            userProfile.customerCategory = "Lacteos";
            userProfile.customDesc = "Trabajo desde los 7 años con quesos, matequilla y leche 100% natural";
            userProfile.customPhone = 312135156;

            Console.WriteLine(userProfile.profile);
        }
    }
}