using System;
using System.Collections.Generic;
using System.Linq;
using Application;

namespace Application
{
    public class FrontEmociones
    {
        private List<Emocion> emociones = new List<Emocion>
        {
            new EmocionAburrimiento(),
            new EmocionAlegria(),
            new EmocionEsperanza(),
            new EmocionIra(),
            new EmocionNostalgico(),
            new EmocionRomance(),
            new EmocionTristeza()
        };

        public void MostrarEmociones()
        {
            Console.WriteLine("Lista de emociones disponibles:");
            for (int i = 0; i < emociones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {emociones[i].Nombre}");
            }
        }

        public Emocion SeleccionarEmocion()
        {
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