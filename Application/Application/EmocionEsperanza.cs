using System;
using System.Collections.Generic;
using System.IO;
using Application;


namespace Application
{
    public class EmocionEsperanza : Emocion
    {
        public EmocionEsperanza()
        {
            Nombre = "Esperanza";
        }
        public override List<EleccionArtista.Cancion> ObtenerCanciones()
        {
            List<EleccionArtista.Cancion> canciones = new List<EleccionArtista.Cancion>();

            string[] lineas = File.ReadAllLines("Esperanza.txt");
            EleccionArtista.Cancion cancionActual = null;

            foreach (string linea in lineas)
            {
                if (linea.StartsWith("Autor:"))
                {
                    cancionActual = new EleccionArtista.Cancion();
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
    }
}

