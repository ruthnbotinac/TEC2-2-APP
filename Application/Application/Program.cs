using System;
using System.Collections.Generic;


namespace CódigoFiguras
{
    class Program
    {
        static void Main()
        {
            //Lista de figuras
            List<string> opciones = new List<string>
        {
            "Triángulo",
            "Cuadrado",
            "Rectángulo",
            "Rombo",
            "Romboide",
            "Trapecio",
            "Trapezoide",
            "Polígono Regular",
            "Círculo",
            "Elipse"
        };

            do //Se genera el ciclo para cada figura
            {
                for (int i = 0; i < opciones.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {opciones[i]}");
                }

                Console.WriteLine("\nSeleccione una figura:\n"); //Selección de figura


                int seleccion;
                if (int.TryParse(Console.ReadLine(), out seleccion) && seleccion >= 1 && seleccion <= opciones.Count)
                {
                    IFigura figura = FiguraFactory.ObtenerFiguraSeleccionada(seleccion);

                    if (figura != null)
                    {
                        //Area o perimetro
                        Console.WriteLine("¿Qué desea hallar, área o perímetro?");
                        string operacion = Console.ReadLine().ToLower();

                        double resultado = 0;

                        switch (operacion)
                        {
                            case "area":
                                resultado = figura.CalcularArea();
                                break;
                            case "perimetro":
                                resultado = figura.CalcularPerimetro();
                                break;
                            default:
                                Console.WriteLine("Operación no válida.");
                                break;
                        }
                        //Arroja el resultado
                        Console.WriteLine($"El resultado es: {resultado}");
                        figura.MostrarInformacion();
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
                //Opción para continuar o finalizar el programa
                Console.WriteLine("¿Desea seleccionar otra figura? (Si/No)");
            } while (Console.ReadLine().Equals("Si", StringComparison.OrdinalIgnoreCase));
        }
    }


}