using static Application.FigurasPlanas;
using static Application.FigurasVolumetricas;

namespace Application
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculadora de Área, Perímetro y Volumen de Figuras");
            Console.WriteLine("1. Figuras 2D");
            Console.WriteLine("2. Figuras 3D");

            Console.Write("Elija una opción (1/2): ");
            int opcionPrincipal = int.Parse(Console.ReadLine());

            if (opcionPrincipal == 1)
            {
                Console.WriteLine("Figuras 2D:");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Círculo");

                Console.Write("Elija una figura (1/2): ");
                int opcionFigura2D = int.Parse(Console.ReadLine());

                if (opcionFigura2D == 1)
                {
                    Console.Write("Ingrese el lado del cuadrado: ");
                    double lado = double.Parse(Console.ReadLine());

                    Cuadrado cuadrado = new Cuadrado { Lado = lado };
                    Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
                    Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro()}");
                }
                else if (opcionFigura2D == 2)
                {
                    Console.Write("Ingrese el radio del círculo: ");
                    double radio = double.Parse(Console.ReadLine());

                    Circulo circulo = new Circulo { Radio = radio };
                    Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
                    Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
            else if (opcionPrincipal == 2)
            {
                Console.WriteLine("Figuras 3D:");
                Console.WriteLine("1. Cubo");

                Console.Write("Elija una figura (1): ");
                int opcionFigura3D = int.Parse(Console.ReadLine());

                if (opcionFigura3D == 1)
                {
                    Console.Write("Ingrese el lado del cubo: ");
                    double ladoCubo = double.Parse(Console.ReadLine());

                    Cubo cubo = new Cubo { Lado = ladoCubo };
                    Console.WriteLine($"Volumen del cubo: {cubo.CalcularVolumen()}");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}