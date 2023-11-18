using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Racion
    {
        private string _id { get; set; }
        private string _producto { get; set; }
        private double _peso { get; set; }
        private string _unidadMedida { get; set; }  
        public string Id { get { return _id; } set { _id = value; } }
        public string Producto { get {return _producto;} set { _producto = value; } }
        public double Peso { get { return _peso;} set {  _peso = value; } }
        public string UnidadMedida { get { return _unidadMedida; } set { _unidadMedida = value; } }

        public Racion(string id, string producto, double peso, string unidadMedida)
        {
            _producto = producto;
            _peso = peso;
            _id = id;
            _unidadMedida = unidadMedida;
            
        }

    }
}
