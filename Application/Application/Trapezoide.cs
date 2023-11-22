using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public class Trapezoide : Figura
    {
        private double BaseMayor { get; set; }
        private double BaseMenor { get; set; }
        private double LadoIzquierdo { get; set; }
        private double LadoDerecho { get; set; }
        private double Altura { get; set; }

        public Trapezoide(double baseMayor, double baseMenor, double ladoIzquierdo, double ladoDerecho, double altura)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            LadoIzquierdo = ladoIzquierdo;
            LadoDerecho = ladoDerecho;
            Altura = altura;
        }

        public override IFigura CrearInstancia()
        {
            Console.WriteLine("Ingrese la longitud de la base mayor del trapezoide:");
            double baseMayor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de la base menor del trapezoide:");
            double baseMenor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud del lado izquierdo del trapezoide:");
            double ladoIzquierdo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud del lado derecho del trapezoide:");
            double ladoDerecho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del trapezoide:");
            double altura = Convert.ToDouble(Console.ReadLine());

            return new Trapezoide(baseMayor, baseMenor, ladoIzquierdo, ladoDerecho, altura);
        }

        public override double CalcularArea()
        {
            return ((BaseMayor + BaseMenor) / 2) * Altura;
        }

        public override double CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + LadoIzquierdo + LadoDerecho;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Trapezoide: ");
            Console.WriteLine($"Base Mayor: {BaseMayor}, Base Menor: {BaseMenor}, Lado Izquierdo: {LadoIzquierdo}, Lado Derecho: {LadoDerecho}, Altura: {Altura}");
        }
    }

}
