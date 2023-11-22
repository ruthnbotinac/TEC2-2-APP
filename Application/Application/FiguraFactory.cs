using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public static class FiguraFactory
    {
        public static IFigura ObtenerFiguraSeleccionada(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return new Triangulo(0, 0, 0).CrearInstancia();
                case 2:
                    return new Cuadrado(0).CrearInstancia();
                case 3:
                    return new Rectangulo(0, 0).CrearInstancia();
                case 4:
                    return new Rombo(0, 0).CrearInstancia();
                case 5:
                    return new Romboide(0, 0).CrearInstancia();
                case 6:
                    return new Trapecio(0, 0, 0, 0, 0).CrearInstancia();
                case 7:
                    return new Trapezoide(0, 0, 0, 0, 0).CrearInstancia();
                case 8:
                    return new PoligonoRegular(0, 0).CrearInstancia();
                case 9:
                    return new Circulo(0).CrearInstancia();
                case 10:
                    return new Elipse(0, 0).CrearInstancia();
                default:
                    Console.WriteLine("Figura no válida.");
                    return null;
            }
        }
    }

}
