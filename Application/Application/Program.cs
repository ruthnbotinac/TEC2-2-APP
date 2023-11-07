using Application.Data;
using Application.Data.Repositorios;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Create");
            Conexion dbConn = new Conexion();
            RacionRepositorio classRepo = new RacionRepositorio(dbConn);
            Racion newRacion = new Racion(string.Empty, "racion1", 1);

            classRepo.Insert(newRacion);

            Console.WriteLine("------FindAll");
            var all = classRepo.FindAll(); 
            foreach (var item in all) 
            {
                Console.WriteLine($"{item.Id} {item.Producto} {item.Peso}");
            }

            /* int op;

             Console.WriteLine("Bienvenido a mi inventario");
             Console.WriteLine("seleccione una opción:\n 1.Crear Usuario\n 2.Iniciar sesión");
             op = int.Parse(Console.ReadLine());
             interaccion.RegistroLogeo(op);
            */
        }
    }
}