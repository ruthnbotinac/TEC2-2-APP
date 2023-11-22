using System;
using Application;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Aprobador
    {

        //propiedades 
        public String nombreAprobador;
        public String departamento;
        public ArrayList requisiciones;

        //encapsulamiento
        public Aprobador()
        {
            requisiciones = new ArrayList();
        }

        public string NombreAprobador
        {
            get { return nombreAprobador; }
            set
            {
                if (value.Length > 4)
                {
                    nombreAprobador = value;
                }
                else
                {
                    throw new ArgumentException("El nombre del aprobador debe tener más de 4 caracteres");
                }
            }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public ArrayList Requisiciones
        {
            get { return requisiciones; }
            private set { requisiciones = value; }
        }
        public void RegistrarAprobador(string nombreAprobador, string departamento)
        {
            NombreAprobador = nombreAprobador;
            Departamento = departamento;
        }
        public void ImprimirDatosAprobador()
        { 
        Console.WriteLine("nombreAprobador: " + NombreAprobador);
        Console.WriteLine("Departamento:" + Departamento);
           
        }

        public void RevisarRequisicion(Requisicion requisicion)
        {
            Console.WriteLine("Fecha: " + requisicion.Fecha);
            Console.WriteLine("Producto: " + requisicion.Producto);
            Console.WriteLine("Cantidad: " + requisicion.Cantidad);
            Console.WriteLine("Unidad de Medida: " + requisicion.UnidadDeMedida);
        }

    }
}
