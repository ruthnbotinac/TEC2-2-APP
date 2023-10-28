using Application;
using System.Collections.Generic;

namespace Application
{
    public class Emocion
    {
        public string Nombre { get; set; }

        public virtual List<Cancion> ObtenerCanciones()
        {
            return new List<Cancion>();
        }
    }
}
