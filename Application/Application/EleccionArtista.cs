using System;
using System.Collections.Generic;
using System.IO;

namespace Application
{
    public class EleccionArtista
    {
        private List<Cancion> canciones;

        public EleccionArtista()
        {
            canciones = new List<Cancion>();
        }

        public class Cancion
        {
            private string autor;
            private string genero;
            private string album;
            private string emocionAsociada;
            private string urlVideo;
            private string urlImagenArtista;
            private string urlImagenAlbum;

            public string Autor
            {
                get { return autor; }
                set { autor = value; }
            }

            public string Genero
            {
                get { return genero; }
                set { genero = value; }
            }

            public string Album
            {
                get { return album; }
                set { album = value; }
            }

            public string EmocionAsociada
            {
                get { return emocionAsociada; }
                set { emocionAsociada = value; }
            }

            public string UrlVideo
            {
                get { return urlVideo; }
                set { urlVideo = value; }
            }

            public string UrlImagenArtista
            {
                get { return urlImagenArtista; }
                set { urlImagenArtista = value; }
            }

            public string UrlImagenAlbum
            {
                get { return urlImagenAlbum; }
                set { urlImagenAlbum = value; }
            }
        }

        public void MostrarArtistasPorEmocion(string emocionSeleccionada)
        {
            canciones = ObtenerCancionesPorEmocion(emocionSeleccionada);

            if (canciones.Count == 0)
            {
                Console.WriteLine($"No se encontraron canciones para la emoción '{emocionSeleccionada}'.");
                return;
            }

            MostrarArtistas(); // Mostrar la lista de artistas

            Console.Write("Elija un artista ingresando el número correspondiente: ");
            int opcion;

            if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 1 && opcion <= canciones.Count)
            {
                MostrarInformacionCancion(canciones[opcion - 1]);
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
            }
        }


        public void MostrarInformacionCancion(Cancion cancion)
        {
            Console.WriteLine($"Información de la canción:");
            Console.WriteLine($"Autor: {cancion.Autor}");
            Console.WriteLine($"Género: {cancion.Genero}");
            Console.WriteLine($"Álbum: {cancion.Album}");
            Console.WriteLine($"Emoción Asociada: {cancion.EmocionAsociada}");
            Console.WriteLine($"URL del Video: {cancion.UrlVideo}");
            Console.WriteLine($"URL de la Imagen del Artista: {cancion.UrlImagenArtista}");
            Console.WriteLine($"URL de la Imagen del Álbum: {cancion.UrlImagenAlbum}");
        }

        private List<Cancion> ObtenerCancionesPorEmocion(string emocionSeleccionada)
        {
            List<Cancion> canciones = new List<Cancion>();

            string[] lineas = File.ReadAllLines($"{emocionSeleccionada}.txt");
            Cancion cancionActual = null;

            foreach (string linea in lineas)
            {
                if (linea.StartsWith("Autor:"))
                {
                    cancionActual = new Cancion();
                    canciones.Add(cancionActual);
                    cancionActual.Autor = linea.Substring("Autor:".Length).Trim();
                }
                else if (cancionActual != null)
                {
                    if (linea.StartsWith("Genero:"))
                    {
                        cancionActual.Genero = linea.Substring("Genero:".Length).Trim();
                    }
                    else if (linea.StartsWith("Álbum:"))
                    {
                        cancionActual.Album = linea.Substring("Álbum:".Length).Trim();
                    }
                    else if (linea.StartsWith("Emoción Asociada:"))
                    {
                        cancionActual.EmocionAsociada = linea.Substring("Emoción Asociada:".Length).Trim();
                    }
                    else if (linea.StartsWith("URL del Video:"))
                    {
                        cancionActual.UrlVideo = linea.Substring("URL del Video:".Length).Trim();
                    }
                    else if (linea.StartsWith("URL de la Imagen del Artista:"))
                    {
                        cancionActual.UrlImagenArtista = linea.Substring("URL de la Imagen del Artista:".Length).Trim();
                    }
                    else if (linea.StartsWith("URL de la Imagen del Álbum:"))
                    {
                        cancionActual.UrlImagenAlbum = linea.Substring("URL de la Imagen del Álbum:".Length).Trim();
                    }
                }
            }

            return canciones;
        }

        public void MostrarArtistas()
        {
            Console.WriteLine("Lista de artistas relacionados con la emoción seleccionada:");
            int contador = 1;

            foreach (Cancion cancion in canciones)
            {
                Console.WriteLine($"{contador}. {cancion.Autor}");
                contador++;
            }
        }

    }
}

