using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class DetalleRequisicion
    {
        private int _id;
        private string _descripcion;
        private int _cantidad;
        private decimal _precioUnitario;
        private string _producto;
        private string _marca;

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string producto;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private string marca;

        public decimal PrecioUnitario
        {
            get { return _precioUnitario; }
            set { _precioUnitario = value; }
        }

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        // Constructor con parámetros
        public DetalleRequisicion(int id, string descripcion, int cantidad, decimal precioUnitario)
        {
            Id = id;
            Descripcion = descripcion;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }

        public DetalleRequisicion(string producto, int cantidad, string marca)
        {
            this.producto = producto;
            Cantidad = cantidad;
            this.marca = marca;
        }

        // Método para calcular el costo total del detalle
        public decimal CalcularCostoTotal()
        {
            return Cantidad * PrecioUnitario;
        }

        // Método para mostrar información detallada del detalle
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del Detalle de Requisición:");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Descripción: " + Descripcion);
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Precio Unitario: " + PrecioUnitario);
            Console.WriteLine("Costo Total: " + CalcularCostoTotal());
        }

        // Método para validar si el detalle es válido (por ejemplo, cantidad y precio positivos)
        public bool EsDetalleValido()
        {
            return Cantidad > 0 && PrecioUnitario > 0;
        }
    }
}



