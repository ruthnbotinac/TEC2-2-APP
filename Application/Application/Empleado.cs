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

      

        // Constructor de la clase Empleado
        public Empleado(string nombre, string departamento, string v)
        {
            Console.WriteLine("Por favor ingrese su nombre completo");
            _nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su departamento");
            _departamento = Console.ReadLine();
           
        }
        public DetalleRequisición CrearDetalleRequisición(string producto, int cantidad, string marca)
        {
            

            DetalleRequisición detalleRequisición = new DetalleRequisición(producto, cantidad, marca);

            if (detallesRequisición == null)
            {
                detallesRequisición = new List<DetalleRequisición>();
            }

            
            detallesRequisición.Add(detalleRequisición);

            // Devuelve el detalle de requisición creado.
            return detalleRequisición;
        }

        private List<DetalleRequisición> detallesRequisición;

        public List<DetalleRequisición> ObtenerDetallesRequisiciónPendientes()
        {
            // Si la lista de detalles de requisición no está inicializada, devuelve una lista vacía.
            if (detallesRequisición == null)
            {
                return new List<DetalleRequisición>();
            }

            // Devuelve la lista de detalles de requisición pendientes.
            return detallesRequisición;



        }
        }
}
