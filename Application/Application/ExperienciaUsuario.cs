using Application;
using System;

namespace Application
{
    public class ExperienciaUsuario
    {
        private FrontEmociones frontEmociones;
        private EleccionArtista eleccionArtista;

        public ExperienciaUsuario(FrontEmociones frontEmociones, EleccionArtista eleccionArtista)
        {
            this.frontEmociones = frontEmociones;
            this.eleccionArtista = eleccionArtista;
        }

        public void InteractuarConUsuario()
        {
            string nuevaEmocion = frontEmociones.SeleccionarEmocion();

            bool continuar = true;

            while (continuar)
            {
                eleccionArtista.MostrarArtistasPorEmocion(nuevaEmocion);

                Console.WriteLine("¿Está de acuerdo con esta canción? (Sí/No)");
                string respuesta = Console.ReadLine();

                if (respuesta.Equals("Sí", StringComparison.OrdinalIgnoreCase))
                {
                    continuar = false;
                    Console.WriteLine("¡Disfrute su canción!");
                }
                else if (respuesta.Equals("No", StringComparison.OrdinalIgnoreCase))
                {
                    nuevaEmocion = frontEmociones.SeleccionarEmocion();
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Por favor, responda 'Sí' o 'No'.");
                }
            }
        }
    }
}