using Application.Data;
using Application.Data.Repositorios;
using static iTextSharp.text.pdf.AcroFields;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conexion dbConn = new Conexion();
            Racion newRacion = new Racion(string.Empty, "racion1", 1, "gramos");
            Usuario newUsuario = new Usuario(string.Empty, "KaterinVera", "12345542");
            RacionRepositorio RacionRepo = new RacionRepositorio(dbConn);
            UsuarioRepositorio UsuarioRepo = new UsuarioRepositorio(dbConn);
            RacionRepositorio racionRepo = new RacionRepositorio(dbConn);

            Console.WriteLine("------Create");
            UsuarioRepo.Insert(newUsuario);
            
            Console.WriteLine("------FindAll");
            var all = UsuarioRepo.FindAll(); 

            all.FirstOrDefault(x => x.UserName = "" &&  )

            foreach (var item in all) 
            {
                Console.WriteLine($"{item.Id} {item.UserName} {item.Password}");
            }
            
            Console.WriteLine("------FindById");
            var oneEntity = UsuarioRepo.FindById(all.First().Id);
            Console.WriteLine($"{oneEntity.Id} {oneEntity.UserName} {oneEntity.Password}");
            
            Console.WriteLine("------Delete");
            UsuarioRepo.Delete(all.First().Id);
            
            Console.WriteLine("-----Update");
            Usuario updateClass = all.Last();
            updateClass.UserName = "BraianFelipeRamirez";
            updateClass.Password = "HORNofSALVATION#2";
            UsuarioRepo.update(updateClass);
           

            /* int op;

             Console.WriteLine("Bienvenido a mi inventario");
             Console.WriteLine("seleccione una opción:\n 1.Crear Usuario\n 2.Iniciar sesión");
             op = int.Parse(Console.ReadLine());
             interaccion.RegistroLogeo(op);
            */
        }
    }
}