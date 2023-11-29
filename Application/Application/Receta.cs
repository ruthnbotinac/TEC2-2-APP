using Application.Data;
using Application.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Receta
    {
       Interaccion interaccion = new Interaccion(); 
        private string _id { get; set; }
        private List<Racion> _raciones { get; set; }
        private string _descripcion { get; set; }
        private string _nombreReceta { get; set; }
        public Receta() { }
        public Receta(List<Racion> raciones, string descripcion, string nombreReceta)
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

        
        public string Descripcion { get {  return _descripcion; } set {  _descripcion = value; } }

        public string NombreReceta { get {  return _nombreReceta; } set {  _nombreReceta = value; } }

        public Dictionary<string,Receta> GetRecetas() {

            return new Dictionary<string, Receta>();

        }
    
        public Receta (string id, string nombreReceta, List<Racion> raciones, string descripcion)
        {
            _id = id;
            _raciones = raciones;
            _descripcion = descripcion;
            _nombreReceta = nombreReceta;
           
        }
        public void AgregarReceta()
        {
            Conexion dbConn = new Conexion();
            RecetaRepositorio recetaRepo = new RecetaRepositorio(dbConn);
            Console.WriteLine("Ingrese le nombre de la receta:");
            string nombreReceta = Console.ReadLine();
            Console.WriteLine("Ingrese el listado de ingredientes con sus respectivos pesos y unidad de medida");
            List<Racion> listaRaciones = new List<Racion>();
            Console.WriteLine("Ingrese la cantidad de productos que desea agregar:");

            if (!int.TryParse(Console.ReadLine(), out int cantidadProductos) || cantidadProductos <= 0)
            {
                Console.WriteLine("Cantidad inválida. Debe ingresar un número mayor que cero.");
                return;
            }

            int contador = 0;

            while (contador < cantidadProductos)
            {
                Console.WriteLine($"\nProducto {contador + 1}:");
                Console.Write("Nombre: ");
                string nombreProducto = Console.ReadLine();

                Console.Write("Cantidad: ");
                if (!double.TryParse(Console.ReadLine(), out double cantidad))
                {
                    Console.WriteLine("Cantidad inválida. Intente nuevamente.");
                    continue;
                }

                Console.Write("Unidad de Medida: ");
                string unidadMedida = Console.ReadLine();

                Racion nuevaRacion = new Racion
                {
                    Producto = nombreProducto,
                    Peso = cantidad,
                    UnidadMedida = unidadMedida
                };

                listaRaciones.Add(nuevaRacion);
                contador++;
            }
            string descripcion;
            Console.WriteLine("Agrege el paso a paso de la receta: ");
            descripcion = Console.ReadLine();


            Receta newReceta = new Receta(string.Empty, nombreReceta, listaRaciones, descripcion);
            Console.WriteLine("------Create");
            recetaRepo.Insert(newReceta);
            interaccion.MenuPrincipal();

        }

    }
}
