using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public class PoligonoRegular : Figura
    {
        private int NumeroLados { get; set; }
        private double LongitudLado { get; set; }

        public PoligonoRegular(int numeroLados, double longitudLado)
        {
            NumeroLados = numeroLados;
            LongitudLado = longitudLado;
        }

        public override IFigura CrearInstancia()
        {
            Console.WriteLine("Ingrese el número de lados del polígono regular:");
            int numeroLados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de un lado del polígono regular:");
            double longitudLado = Convert.ToDouble(Console.ReadLine());

            return new PoligonoRegular(numeroLados, longitudLado);
        }

        public override double CalcularArea()
        {
            return (NumeroLados * Math.Pow(LongitudLado, 2)) / (4 * Math.Tan(Math.PI / NumeroLados));
        }

        public override double CalcularPerimetro()
        {
            return NumeroLados * LongitudLado;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Polígono Regular ({NumeroLados} lados): ");
            Console.WriteLine($"Longitud de un lado: {LongitudLado}");
        }
    }

}
