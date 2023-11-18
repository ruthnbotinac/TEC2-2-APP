using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Usuario
    {
        private  string _userName = "BraianRamirez";
        private  string _password = "GETSUGAtenshou";
        private string _id { get; set; }
        public string Id 
        {
            get { return _id; }
            set { _id = value; }
        }
        
        
        public  string UserName
        {
            get { return _userName; }
            set { _userName = value; }
            
        }
        public  string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public void Acceso( string username, string password)
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

        public Usuario()
        {
                
        }
        public Usuario(string id, string username, string password)
        {
            _password = password;
            _userName = username;
            _id = id;
        }


    }
}
