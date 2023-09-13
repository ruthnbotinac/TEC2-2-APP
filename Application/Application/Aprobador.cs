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
            _Id = id;
            _nombre = nombre;
            _rol = rol;
        }

        //Constructor
        public Aprobador()
        {

        }
    }
  }
