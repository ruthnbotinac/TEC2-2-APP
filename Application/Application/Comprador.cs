using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Comprador
    {
        private string _nombre;
        private string _rol;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Rol
        { 
            get{ return _rol;}
            set { _rol = value; }
        }
        
        public Comprador(string nombre, string rol) {

            Console.WriteLine("Comprador");
            Console.Write("Por favor ingrese su nombre");
            _nombre = Console.ReadLine();
            Console.Write("Por favor ingrese su rol");
            _rol = rol; 


         
        }
    }
}
