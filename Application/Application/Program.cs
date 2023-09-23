using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Application
{
    public class Program
    {
        static List<Log_In> usuarios = new List<Log_In>();
        static List<Profile> perfil= new List<Profile>();
        static void Main(string[] args)
            
        {
            Boolean nextStep = false;
            while (nextStep==false)
            {
                Console.WriteLine("Bienvenido a (...):");
                Console.WriteLine("1. Iniciar sesión");
                Console.WriteLine("2. Registrarse");
                Console.WriteLine("3. ¿Olvidaste la contraseña?");
                Console.WriteLine("4. Salir");
                Console.Write("Por favor, seleccione una opción: ");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            nextStep = IniciarSesion();
                            if (nextStep == true) {
                                Profile();
                            }
                            break;
                        case 2:
                            RegistrarUsuario();
                            break;
                        case 3:
                            Console.WriteLine("jjj");
                            return;
                        case 4:
                            Console.WriteLine("¡Hasta luego!");
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                }
            }
        }
        static Boolean IniciarSesion()
        {
            Console.Write("Ingrese su nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string contrasena = Console.ReadLine();

            Log_In usuario = usuarios.FirstOrDefault(u => u.e_mail == nombreUsuario && u.key == contrasena);

            if (usuario != null)
            {
                Console.WriteLine($"Inicio de sesión exitoso. ¡Bienvenido, {usuario.e_mail}!");
                return true;
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
                return false;   
            }
        }
        static void RegistrarUsuario()
        {
            Console.Write("Ingrese un nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();
            Profile profile = new Profile();
            // Verificar si el nombre de usuario ya existe
            if (usuarios.Any(u => u.e_mail == nombreUsuario))
            {
                Console.WriteLine("El nombre de usuario ya existe. Por favor, elija otro.");
                return;
            }
            if (EsCorreoElectronicoValido(nombreUsuario))
            {
               Console.WriteLine("La dirección de correo electrónico es válida.");
            }
            else
            {
                Console.WriteLine("La dirección de correo electrónico no es válida.");
            }

            Console.Write("Ingrese una contraseña: ");
            string contrasena = Console.ReadLine();
            Console.Write("Ingrese un correo alternativo: ");
            string alternativeEmail= Console.ReadLine();
            usuarios.Add(new Log_In(nombreUsuario, contrasena, alternativeEmail));
            Console.Write("Ingrese su nombre");
            String nombre= Console.ReadLine();
            Console.Write("Ingrese su apellido");
            String apellidos= Console.ReadLine();
            Console.WriteLine("Ingrese su Id:");
            int DnI = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su edad:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un nombre de usuario:");
            string alias = Console.ReadLine();
            Console.WriteLine("Ingrese una categoria");
            String category= Console.ReadLine();
            Console.WriteLine("Ingrese su telefono de contacto:");
            int telefono= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una descripcion sobre usted y sus productos");
            String descripcion= Console.ReadLine();
            int iD = 1;
            
            Console.WriteLine("Registro exitoso. Ahora puede iniciar sesión con su nuevo usuario.");
        }
        static bool EsCorreoElectronicoValido(string email)
        {
            // Patrón de expresión regular para validar direcciones de correo electrónico
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Usar Regex.IsMatch para verificar si la cadena cumple con el patrón
            return Regex.IsMatch(email, patron);
        }

        static void Profile() { 
        
        
        }
    }







































    //private static Log_In log_In = new Log_In();
    //private static Profile _profile= new Profile();
    //static void Main(string[] args)
    //{

    //    //Profile userProfile = new Profile();
    //    //userProfile.firstName = "Jose";
    //    //userProfile.lastName = "Cardenas";
    //    //userProfile.customerId = 122214;
    //    //userProfile.e_mail = "cardenas123@best.com";
    //    //userProfile.CustuserName = "JC Ortiz";
    //    //userProfile.customerAge = 39;
    //    //userProfile.customerCategory = "Lacteos";
    //    //userProfile.customDesc = "Trabajo desde los 7 años con quesos, matequilla y leche 100% natural";
    //    //userProfile.customPhone = 312135156;

    //    //Console.WriteLine(userProfile.profile);
    //    newAccount();
    //    Console.WriteLine(_profile.profile);


    // }
    //public static void newAccount() {
    //    Console.WriteLine("Ingresa el correco electronico");
    //    log_In.e_mail = Console.ReadLine();
    //    Console.WriteLine("Ingresa la contraseña");
    //    log_In.key = Console.ReadLine();
    //    Console.WriteLine("Ingresa un correo alternativo");
    //    log_In.otherEmail = Console.ReadLine();
    //    //_profile.newprofile(log_In);

    //    Console.WriteLine("Ingresa tu nombre(Primer y segundo nombre)");
    //    _profile.firstName = Console.ReadLine();
    //    Console.WriteLine("Ingresa tu apellido(Primer y segundo apellido)");
    //    _profile.lastName = Console.ReadLine();
    //    _profile.e_mail = log_In.key; //Es mejor por herencia
    //    Console.WriteLine("Ingresa tu edad");
    //    _profile.customerAge= int.Parse(Console.ReadLine());
    //    Console.WriteLine("Ingresa tu Numero de Documento(sin espacios, no puntos y sin comas)");
    //    _profile.customerId = int.Parse(Console.ReadLine());
    //    Console.WriteLine("Ingresa un nombre de usuario (Alias o nombre)");
    //    _profile.CustuserName = Console.ReadLine();
    //    Console.WriteLine("Tu ubic es: " + "-444,0000");
    //    Console.WriteLine("Ingresa tu numero de telefono");
    //    _profile.customPhone= int.Parse(Console.ReadLine());
    //}
}
