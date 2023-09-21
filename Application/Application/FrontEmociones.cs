using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class FrontEmociones
    {
        private List<string> emociones = new List<string>
        {
            "Ira", "Alegria", "Tristeza", "Esperanza", "Romance", "Aburrimiento", "Nostalgico"
        };

        public void MostrarEmociones()
        {
            Console.WriteLine("Lista de emociones disponibles:");
            for (int i = 0; i < emociones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {emociones[i]}");
            }
        }

        public string SeleccionarEmocion()
        {
            Console.WriteLine("Lista de emociones disponibles:");
            for (int i = 0; i < emociones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {emociones[i]}");
            }

            Console.Write("Elija una emoción ingresando el número correspondiente: ");
            int opcion;

            if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 1 && opcion <= emociones.Count)
            {
                return emociones[opcion - 1];
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                return null;
            }
        }
    }

}