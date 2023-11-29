using Application.Data;
using Application.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace Application
{
    public class Inventario
    {
        Interaccion interaccion = new Interaccion();    
        private string _producto { get; set; }
        private double _peso { get; set; }
        private string _unidadMedida { get; set; }
        private string _id { get; set; }

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        public double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
        public string UnidadMedida
        {
            get { return _unidadMedida; }
            set { _unidadMedida = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Inventario()
        {
            
        }

        public Inventario(string id, string producto, double peso, string unidadMedida )
        {
            _producto = producto;
            _peso = peso;
            _unidadMedida = unidadMedida;
            _id = id;
        }
        public void AgregarMateriaPrima(string nombreProducto)
        {
            Conexion dbConn = new Conexion();
            InventarioRepositorio inventarioRepo = new InventarioRepositorio(dbConn);
            Console.WriteLine("------FindAll");
            var all = inventarioRepo.FindAll();
            var productExist = all.FirstOrDefault(x => x.Producto == nombreProducto);
            if (productExist == null)
            {
                Console.WriteLine("Ingrese el peso o la cantidad del producto:");
                Peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la unidad de medida:");
                UnidadMedida = Console.ReadLine();
                Inventario newInventario = new Inventario(string.Empty, nombreProducto, Peso, UnidadMedida);
                Console.WriteLine("------Create");
                inventarioRepo.Insert(newInventario);
            }
            else
            {
                Console.WriteLine("El producto ya existe en el inventario, actualize peso/cantidad");
                Console.WriteLine("-----Update");
                Console.WriteLine("Ingrese el peso o la cantidad del producto:");
                Peso = double.Parse(Console.ReadLine());
                productExist.Peso = Peso;
                inventarioRepo.update(productExist);
            }

            interaccion.MenuPrincipal();
        }
        public void BajasMateriaPrima(string NombreProducto)
        {
            Conexion dbConn = new Conexion();
            InventarioRepositorio inventarioRepo = new InventarioRepositorio(dbConn);
            Console.WriteLine("------FindAll");
            var all = inventarioRepo.FindAll();
            var productExist = all.FirstOrDefault(x => x.Producto == NombreProducto);
            if (productExist == null)
            {
                Console.WriteLine("El producto ingresado no existe en el inventario.");

            }
            else
            {
                Console.WriteLine("El producto encontrado, ingrese la nueva cantidad/peso");
                Console.WriteLine("-----Update");
                Console.WriteLine("Ingrese el peso o la cantidad del producto:");
                Peso = double.Parse(Console.ReadLine());
                productExist.Peso = Peso;
                inventarioRepo.update(productExist);

            }
            interaccion.MenuPrincipal();
        }
        public void MostrarInventario()
        {
            Conexion dbConn = new Conexion();
            InventarioRepositorio inventarioRepo = new InventarioRepositorio(dbConn);
            Console.WriteLine("------FindAll");
            var all = inventarioRepo.FindAll();
            foreach (var item in all)
            {
                Console.WriteLine($"{item.Producto} {item.Peso} {item.UnidadMedida}");
            }
            interaccion.MenuPrincipal();
        }
    }
}

