namespace Application
{
    internal class FigurasVolumetricas
    {
        // Clase base para figuras 3D
        public abstract class Figura3D
        {
            public abstract double CalcularVolumen();
        }
        // Clase para representar un cubo
        public class Cubo : Figura3D
        {
            public double Lado { get; set; }

            public override double CalcularVolumen()
            {
                return Math.Pow(Lado, 3);
            }
            public void CalcularArea()
            {

            }
            public void Formulas()
            {

            }
        }
    }
}
