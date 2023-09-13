using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Receta
    {
        public Receta() { }
        public Receta(List<Racion> raciones, Dictionary<int, string> descripcion, string nombreReceta)
        {
            _raciones = raciones;
            _descripcion = descripcion;
            _nombreReceta = nombreReceta;
        }

        private List<Racion> _raciones { get; set; }
        private Dictionary<int, string> _descripcion { get; set; }
        private string _nombreReceta { get; set; }


        public List<Racion> Raciones { get { return _raciones; } set { _raciones = value; } }

        
        public Dictionary<int, string> Descripcion { get {  return _descripcion; } set {  _descripcion = value; } }

        public string NombreReceta { get {  return _nombreReceta; } set {  _nombreReceta = value; } }




        public Dictionary<string,Receta> GetRecetas() {

            return new Dictionary<string, Receta>();


        }

    }
}
