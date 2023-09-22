using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
   public class Requisicion
    {
        private int _id;
        private DateTime _fechaCreacion;
        private string _estado;
        private Empleado _empleadoCreador;
        private List<DetalleRequisición> _detalles;

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public DateTime FechaCreacion
        {
            get { return _fechaCreacion; }
            private set { _fechaCreacion = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public Empleado EmpleadoCreador
        {
            get { return _empleadoCreador; }
            private set { _empleadoCreador = value; }
        }

        public List<DetalleRequisición> Detalles
        {
            get { return _detalles; }
            private set { _detalles = value; }
        }

        // Constructor con parámetros
        public Requisicion(int id, DateTime fechaCreacion, string estado, Empleado empleadoCreador)
        {
            Id = id;
            FechaCreacion = fechaCreacion;
            Estado = estado;
            EmpleadoCreador = empleadoCreador;
            Detalles = new List<DetalleRequisición>();
        }

        // Método para agregar un detalle a la requisición
        public void AgregarDetalle(DetalleRequisición detalle)
        {
            Detalles.Add(detalle);
        }

        // Método para mostrar información de la requisición
        public void MostrarInformacion()
        {
            Console.WriteLine("Información de la Requisición:");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Fecha de Creación: " + FechaCreacion);
            Console.WriteLine("Estado: " + Estado);
            Console.WriteLine("Empleado Creador: " + EmpleadoCreador.Nombre);
            Console.WriteLine("Detalles:");

            foreach (var detalle in Detalles)
            {
                Console.WriteLine($"  - Descripción: {detalle.Descripcion}, Cantidad: {detalle.Cantidad}, Precio Unitario: {detalle.PrecioUnitario}");
            }
        }
    }







}


