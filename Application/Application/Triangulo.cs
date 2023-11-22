using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public class Triangulo : Figura
    {
        //Variables para número de lados 
        private double LadoA { get; set; }
        private double LadoB { get; set; }
        private double LadoC { get; set; }

        public override IFigura CrearInstancia()
        {
            //Mensaje por consola para solicitar los lados al usuario
            Console.WriteLine("Ingrese el lado A del triángulo:");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el lado B del triángulo:");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el lado C del triángulo:");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            return new Triangulo(ladoA, ladoB, ladoC);
        }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public override double CalcularArea()
        {
            // Fórmula de Herón para el área de un triángulo
            double s = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
        }

        public override double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Triángulo: ");
            Console.WriteLine($"Lado A: {LadoA}, Lado B: {LadoB}, Lado C: {LadoC}");

            //Aca debe ir la explicación sobre cómo hacer el cálculo
        }
    }

}
