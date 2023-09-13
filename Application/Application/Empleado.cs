using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Empleado
    {
        private string _nombre;
        private string _departamento;
        private string _cadena;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        public string Cadena
        {
            get { return _cadena; }
            set { _cadena = value; }
        }

        // Constructor de la clase Empleado
        public Empleado(string nombre, string departamento, string cadena)
        {
            _nombre = nombre;
            _departamento = departamento;
            _cadena = cadena;
        }

    }
}
