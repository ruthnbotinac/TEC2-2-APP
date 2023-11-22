using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public class Circulo : Figura
    {
        private double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override IFigura CrearInstancia()
        {
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());

            return new Circulo(radio);
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Círculo: ");
            Console.WriteLine($"Radio: {Radio}");
        }
    }

}
