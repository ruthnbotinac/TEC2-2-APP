using System;
using System.Collections.Generic;

namespace Application
{
    public class LugaresFrecuentes
    {
        private List<LugarFrecuente> lugares;

        public LugaresFrecuentes()
        {
            lugares = new List<LugarFrecuente>();
        }

        public void AgregarLugar(string nombre, double latitud, double longitud)
        {
            LugarFrecuente lugar = new LugarFrecuente(nombre, latitud, longitud);
            lugares.Add(lugar);
            Console.WriteLine($"Lugar frecuente '{nombre}' agregado con éxito.");
        }

        public List<LugarFrecuente> ObtenerLugares()
        {
            return lugares;
        }
    }

    public class LugarFrecuente
    {
        private string nombre;
        private double latitud;
        private double longitud;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }

        public double Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        public LugarFrecuente(string nombre, double latitud, double longitud)
        {
            Nombre = nombre;
            Latitud = latitud;
            Longitud = longitud;
        }
    }
}