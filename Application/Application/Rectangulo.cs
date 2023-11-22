using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public class Rectangulo : Figura
    {
        private double LadoBase { get; set; }
        private double Altura { get; set; }

        public Rectangulo(double ladoBase, double altura)
        {
            LadoBase = ladoBase;
            Altura = altura;
        }

        public override IFigura CrearInstancia()
        {
            Console.WriteLine("Ingrese la longitud de la base del rectángulo:");
            double ladoBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del rectángulo:");
            double altura = Convert.ToDouble(Console.ReadLine());

            return new Rectangulo(ladoBase, altura);
        }

        public override double CalcularArea()
        {
            return LadoBase * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (LadoBase + Altura);
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Rectángulo: ");
            Console.WriteLine($"Base: {LadoBase}, Altura: {Altura}");
        }
    }

}
