using System;

namespace Application
{
    public class FigurasPlanas
    {
        // Clase base para figuras 2D
        public abstract class Figura2D
        {
            public abstract double CalcularArea();
            public abstract double CalcularPerimetro();
        }

        // Clase para representar un cuadrado
        public class Cuadrado : Figura2D
        {
            public double Lado { get; set; }

            public override double CalcularArea()
            {
                return Lado * Lado;
            }

            public override double CalcularPerimetro()
            {
                return 4 * Lado;
            }
        }

        // Clase para representar un círculo
        public class Circulo : Figura2D
        {
            public double Radio { get; set; }

            public override double CalcularArea()
            {
                return Math.PI * Math.Pow(Radio, 2);
            }

            public override double CalcularPerimetro()
            {
                return 2 * Math.PI * Radio;
            }
        }

    }

}
