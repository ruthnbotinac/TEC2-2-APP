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
        private int contador = 0000;
        public double Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }
        public string UnidadDeMedida { get; set; }



        public void RegistroRequisicion()
        {
            Console.WriteLine("Por favor ingrese los datos de la requisión");
            DateTime fecha;
            string producto, unidadDeMedida;
            double cantidad;

            Console.WriteLine("Fecha de la requisición (dd/MM/yyyy): ");
            fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Producto: ");
            producto = Console.ReadLine();
            Console.WriteLine("Cantidad: ");
            cantidad = double.Parse(Console.ReadLine());
            Console.WriteLine("Indique la unidad de medida: ");
            unidadDeMedida = Console.ReadLine();
            GenerarRequisicion(fecha, producto, cantidad, unidadDeMedida, contador);
        }
         
        public void GenerarRequisicion(DateTime fecha, string producto, double cantidad, string unidadDeMedida, int contador)
        {
           Console.WriteLine("Producto:  " + producto + " Cantidad:  " + cantidad + " Unidad de medida:  " + unidadDeMedida + "Serial:  " + contador);

            
            contador++;

            Console.WriteLine(contador);
        }


    }
}       

