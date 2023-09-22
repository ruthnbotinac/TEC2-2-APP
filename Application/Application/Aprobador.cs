using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Aprobador
    {
        private int _Id;
        private string _nombre;
        private string _rol;

        public int Id { get; set; }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        // Constructor con parámetros
        public Aprobador(int id, string nombre, string rol)
        {
            Console.WriteLine("Por favor ingrese su ID");
            _Id = int.Parse(Console.ReadLine());    
            Console.WriteLine("Por favor ingrese su nombre");
            _nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su rol");
            _rol = Console.ReadLine();
        }
    }
  }
