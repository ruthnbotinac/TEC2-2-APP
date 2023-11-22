using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public class Cuadrado : Figura
    {
        //Variables para número de lados 
        private double Lado { get; set; }

        public override IFigura CrearInstancia()
        {
            Console.WriteLine("Ingrese el lado del cuadrado:");
            double lado = Convert.ToDouble(Console.ReadLine());

            return new Cuadrado(lado);
        }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Cuadrado: ");
            Console.WriteLine($"Lado: {Lado}");
        }
    }
}
