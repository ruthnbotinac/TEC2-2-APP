using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigoFiguras
{
    public interface IFigura
    {
        double CalcularArea();
        double CalcularPerimetro();
        void MostrarInformacion();
        IFigura CrearInstancia();
    }

}
