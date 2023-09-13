using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Application
{
    public class FigurasPlanas
    {
        private double _lado { get; set; }
        public double Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }

        private double _base { get; set; }
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        private double _altura { get; set; }
        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public static void ExecuteExercise()
        {
            Console.WriteLine("Elegir una de las opciones");
            string opc;
            opc = Console.ReadLine();
            Console.WriteLine("La opcion es " + opc);
            switch (opc)
            {
                case "1":
                    AreaCuadrado();
                    break;

                case "2":
                    AreaRectangulo();
                    break;

                case "3":
                    AreaTriangulo();
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }

        public static void AreaCuadrado()
        {
            FigurasPlanas figuras = new FigurasPlanas();

            Console.WriteLine();
            Console.WriteLine("Área de Cuadrado");
            Console.Write("Ingresa un lado del cuadrado: ");

            figuras.Lado = double.Parse(Console.ReadLine());

            double area = figuras.Lado * figuras.Lado;
            Console.WriteLine("");
            Console.WriteLine($"El área del cuadrado con lado {figuras.Lado} es: {area}");
        }

        public static void AreaRectangulo()
        {
            FigurasPlanas figuras = new FigurasPlanas();

            Console.WriteLine("Area del Rectangulo");
            Console.Write("Ingresa la base del Rectangulo: ");
            figuras.Base = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la altura del Rectangulo: ");
            figuras.Altura = double.Parse(Console.ReadLine());

            double Area = figuras.Base * figuras.Altura;

            Console.WriteLine("");
            Console.WriteLine($"El Area del Rectangulo es: {Area}");
        }

        public static void AreaTriangulo()
        {
            FigurasPlanas figuras = new FigurasPlanas();

            Console.WriteLine("Area del Triangulo");
            Console.Write("Ingresa la base del Triangulo: ");
            figuras.Base = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la altura del Triangulo: ");
            figuras.Altura = double.Parse(Console.ReadLine());

            double Area = (figuras.Base * figuras.Altura) / 2;

            Console.WriteLine("");
            Console.WriteLine($"El Area del Triangulo es: {Area}");
        }
    }

}
