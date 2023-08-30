using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class usuario
    {
        private static string _userName = "BraianRamirez";
        private static string _password = "GETSUGAtenshou";

        public static string UserName
        {
            get { return _userName; }
            set { _userName = value; }
            
        }
        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public static void Acceso( string username, string password)
        {
            if(username.Equals(UserName) && password.Equals(Password))
            {
                Console.WriteLine("Bienvenido a mi inventario " + UserName);
                interaccion.MenuPrincipal();
            }
            else
            {
                Console.WriteLine("Usuario o Contraseña invalidos.");
            }
        }

      
    }
}
