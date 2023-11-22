using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public class Rombo : Figura
    {
        private double DiagonalMayor { get; set; }
        private double DiagonalMenor { get; set; }

        public Rombo(double diagonalMayor, double diagonalMenor)
        {
            DiagonalMayor = diagonalMayor;
            DiagonalMenor = diagonalMenor;
        }

        public override IFigura CrearInstancia()
        {
            Console.WriteLine("Ingrese la longitud de la diagonal mayor del rombo:");
            double diagonalMayor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de la diagonal menor del rombo:");
            double diagonalMenor = Convert.ToDouble(Console.ReadLine());

            return new Rombo(diagonalMayor, diagonalMenor);
        }

        public override double CalcularArea()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Math.Sqrt((Math.Pow(DiagonalMayor / 2, 2) + Math.Pow(DiagonalMenor / 2, 2)));
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Rombo: ");
            //Console.WriteLine($"Diagonal Mayor: {DiagonalMayor}, Diagonal Menor: {DiagonalMenor}");
            Console.WriteLine("Paso a paso");
        }
    }

}
