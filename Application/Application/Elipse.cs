using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public class Elipse : Figura
    {
        private double SemiejeMayor { get; set; }
        private double SemiejeMenor { get; set; }

        public Elipse(double semiejeMayor, double semiejeMenor)
        {
            SemiejeMayor = semiejeMayor;
            SemiejeMenor = semiejeMenor;
        }

        public override IFigura CrearInstancia()
        {
            Console.WriteLine("Ingrese el semieje mayor de la elipse:");
            double semiejeMayor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el semieje menor de la elipse:");
            double semiejeMenor = Convert.ToDouble(Console.ReadLine());

            return new Elipse(semiejeMayor, semiejeMenor);
        }

        public override double CalcularArea()
        {
            return Math.PI * SemiejeMayor * SemiejeMenor;
        }

        public override double CalcularPerimetro()
        {
            // No hay una fórmula simple para el perímetro de una elipse.
            Console.WriteLine("El perímetro de la elipse no tiene una fórmula simple.");
            return -1;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Elipse: ");
            Console.WriteLine($"Semieje Mayor: {SemiejeMayor}, Semieje Menor: {SemiejeMenor}");
        }
    }

}
