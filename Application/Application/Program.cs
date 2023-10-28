using System;
using System.Collections.Generic;
using Application;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aplicación de elección de artistas por emoción.");

            FrontEmociones frontEmociones = new FrontEmociones();
            ExperienciaUsuario experienciaUsuario = new ExperienciaUsuario(frontEmociones);

            experienciaUsuario.InteractuarConUsuario();

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
