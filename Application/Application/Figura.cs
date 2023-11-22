using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public abstract class Figura : IFigura
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public abstract void MostrarInformacion();
        public abstract IFigura CrearInstancia();
    }

}
