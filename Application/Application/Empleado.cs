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
            _nombre = nombre;
            _departamento = departamento;
           
        }
        public DetalleRequisición CrearDetalleRequisición(string producto, int cantidad, string marca)
        {
            // Crear una instancia de DetalleRequisición y asignar los valores proporcionados.


            DetalleRequisición detalleRequisición = new DetalleRequisición(producto, cantidad, marca);

            // Aquí puedes realizar más acciones, como registrar el detalle en una lista de detalles de requisición pendientes.
            // Por ejemplo, puedes tener una lista en la clase Empleado para almacenar los detalles de requisición.

            // Crear una lista si no existe (esto debe hacerse en el constructor de la clase Empleado o en otro lugar apropiado).
            if (detallesRequisición == null)
            {
                detallesRequisición = new List<DetalleRequisición>();
            }

            // Agregar el detalle a la lista de detalles de requisición pendientes.
            detallesRequisición.Add(detalleRequisición);

            // Devuelve el detalle de requisición creado.
            return detalleRequisición;
        }

        // Puedes tener una lista para almacenar los detalles de requisición pendientes en la clase Empleado.
        private List<DetalleRequisición> detallesRequisición;

        // Método para obtener todos los detalles de requisición pendientes de este empleado.
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
