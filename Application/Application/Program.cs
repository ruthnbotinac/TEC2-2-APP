using static Application.FigurasPlanas;
using static Application.FigurasVolumetricas;

namespace Application
{
    public class Program
    {
        static void Main()
        {
            int opciones = 0;

            while (opciones != 3)
            {

                Console.WriteLine("Calculadora de Área, Perímetro y Volumen de Figuras");
                Console.WriteLine("1. Figuras 2D");
                Console.WriteLine("2. Figuras 3D");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Ingrese una opción");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {

                    switch (opciones)
                    {
                        case 1:
                            int opcionFigura3D;
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
                                circulo.Formulas();
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida.");
                            }

                            break;
                        case 2:

                            Console.WriteLine("Figuras 3D:");
                            Console.WriteLine("1. Cubo");

                            Console.Write("Elija una figura (1): ");
                            opcionFigura3D = int.Parse(Console.ReadLine());

                            if (opcionFigura3D == 1)
                            {
                                Console.Write("Ingrese el lado del cubo: ");
                                double ladoCubo = double.Parse(Console.ReadLine());

                                Cubo cubo = new Cubo { Lado = ladoCubo };
                                Console.WriteLine($"Volumen del cubo: {cubo.CalcularVolumen()}");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Hasta luego");
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una opción válida");
                }
            }
        }
    }
}