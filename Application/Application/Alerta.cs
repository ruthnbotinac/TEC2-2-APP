using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Alerta
    {

        private string ubicacion;
        private int hora;
        private int numero;
        private DateTime fecha;

       // DateTime fecha = new DateTime(2023, 09, 11);///


        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }


        public int Age
        {
            get { return age; }
            set
            {
                if (age < 18)
                {
                    throw new Exception("Invalid Age");
                }
                else
                {
                    age = value;
                }

            }
        }
    }


}
