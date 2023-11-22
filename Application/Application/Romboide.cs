using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public class Romboide : Figura
    {
        private double BaseMayor { get; set; }
        private double Altura { get; set; }

        public Romboide(double baseMayor, double altura)
        {
            BaseMayor = baseMayor;
            Altura = altura;
        }

        public override IFigura CrearInstancia()
        {
            Console.WriteLine("Ingrese la longitud de la base mayor del romboide:");
            double baseMayor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del romboide:");
            double altura = Convert.ToDouble(Console.ReadLine());

            return new Romboide(baseMayor, altura);
        }

        public override double CalcularArea()
        {
            return BaseMayor * Altura;
        }

        public override double CalcularPerimetro()
        {
            // En un romboide no hay una fórmula simple para el perímetro.
            Console.WriteLine("El perímetro del romboide no tiene una fórmula simple.");
            return -1;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Romboide: ");
            Console.WriteLine($"Base Mayor: {BaseMayor}, Altura: {Altura}");
        }
    }

}
