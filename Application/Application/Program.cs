using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Application
{
    public class Program
    {
        private static Log_In log_In = new Log_In();
        private static Profile _profile= new Profile();
        static void Main(string[] args)
        {

            //Profile userProfile = new Profile();
            //userProfile.firstName = "Jose";
            //userProfile.lastName = "Cardenas";
            //userProfile.customerId = 122214;
            //userProfile.e_mail = "cardenas123@best.com";
            //userProfile.CustuserName = "JC Ortiz";
            //userProfile.customerAge = 39;
            //userProfile.customerCategory = "Lacteos";
            //userProfile.customDesc = "Trabajo desde los 7 años con quesos, matequilla y leche 100% natural";
            //userProfile.customPhone = 312135156;

            //Console.WriteLine(userProfile.profile);
            newAccount();
            Console.WriteLine(_profile.profile);
           
   
        }
        public static void newAccount() {
            Console.WriteLine("Ingresa el correco electronico");
            log_In.e_mail = Console.ReadLine();
            Console.WriteLine("Ingresa la contraseña");
            log_In.key = Console.ReadLine();
            Console.WriteLine("Ingresa un correo alternativo");
            log_In.otherEmail = Console.ReadLine();
            //_profile.newprofile(log_In);
           
            Console.WriteLine("Ingresa tu nombre(Primer y segundo nombre)");
            _profile.firstName = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido(Primer y segundo apellido)");
            _profile.lastName = Console.ReadLine();
            _profile.e_mail = log_In.key; //Es mejor por herencia
            Console.WriteLine("Ingresa tu edad");
            _profile.customerAge= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu Numero de Documento(sin espacios, no puntos y sin comas)");
            _profile.customerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un nombre de usuario (Alias o nombre)");
            _profile.CustuserName = Console.ReadLine();
            Console.WriteLine("Tu ubic es: " + "-444,0000");
            Console.WriteLine("Ingresa tu numero de telefono");
            _profile.customPhone= int.Parse(Console.ReadLine());
        }
    }
}