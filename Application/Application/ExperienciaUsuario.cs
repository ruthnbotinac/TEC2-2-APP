using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;


namespace Application
{
    public class ExperienciaUsuario
    {

        private FrontEmociones frontEmociones;

        public ExperienciaUsuario(FrontEmociones frontEmociones)
        {
            this.frontEmociones = frontEmociones;
        }



        public void InteractuarConUsuario()
        {
            bool continuar = true;

            while (continuar)
            {
                frontEmociones.MostrarEmociones();
                Emocion nuevaEmocion = frontEmociones.SeleccionarEmocion();

                if (nuevaEmocion != null)
                {

                    EleccionArtista eleccionArtista = new EleccionArtista();
                    List<EleccionArtista.Cancion> canciones = nuevaEmocion.ObtenerCanciones();
                    eleccionArtista.MostrarArtistas(canciones);

                    Console.WriteLine("¿Está de acuerdo con esta canción? (si/no): ");
                    string respuesta = Console.ReadLine();

                    if (respuesta.Equals("si", StringComparison.OrdinalIgnoreCase))
                    {
                        continuar = false;
                        Console.WriteLine("¡Disfrute su canción!");
                    }
                    else if (respuesta.Equals("no", StringComparison.OrdinalIgnoreCase))
                    {
                        // Volver a seleccionar una emoción
                    }
                    else
                    {
                        Console.WriteLine("Respuesta no válida. Por favor, responda 'si' o 'no'.");
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                }
            }
        }
    }
}
