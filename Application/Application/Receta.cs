using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Receta
    {
        public Dictionary<string, double> CheesecakeQuesoPaipa { get; set; }
        private string _id { get; set; }
        private List<Racion> _raciones { get; set; }
        private Dictionary<int, string> _descripcion { get; set; }
        private string _nombreReceta { get; set; }
        public Receta() { }
        public Receta(List<Racion> raciones, Dictionary<int, string> descripcion, string nombreReceta)
        {
            _raciones = raciones;
            _descripcion = descripcion;
            _nombreReceta = nombreReceta;
        }

        

        public string Id  
        {
            get { return _id; }
            set { _id = value; }
        }
        public List<Racion> Raciones { get { return _raciones; } set { _raciones = value; } }

        
        public Dictionary<int, string> Descripcion { get {  return _descripcion; } set {  _descripcion = value; } }

        public string NombreReceta { get {  return _nombreReceta; } set {  _nombreReceta = value; } }

        public Dictionary<string,Receta> GetRecetas() {

            return new Dictionary<string, Receta>();


        }
        public void recetario()
        {
            CheesecakeQuesoPaipa = new Dictionary<string, double>();

            CheesecakeQuesoPaipa["Azúcar"] = 384;
            CheesecakeQuesoPaipa["Crema de leche"] = 768;
            CheesecakeQuesoPaipa["Huevos"] = 842;
            CheesecakeQuesoPaipa["Queso crema"] = 1840;
            CheesecakeQuesoPaipa["Queso azul"] = 8;
            CheesecakeQuesoPaipa["Queso paipa"] = 150;
            CheesecakeQuesoPaipa["Sal"] = 15;
        }

        public Receta (string id, string nombreReceta, List<Racion> raciones, Dictionary<int, string> descripcion)
        {
            _id = id;
            _raciones = raciones;
            _descripcion = descripcion;
            _nombreReceta = nombreReceta;
           
        }
        
    }
}
