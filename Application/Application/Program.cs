namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Conexion dbConn = new Conexion();
             Racion newRacion = new Racion(string.Empty, "racion1", 1, "gramos");
             Usuario newUsuario = new Usuario(string.Empty, "KaterinVera", "12345542");
             //Inventario newInventario = new Inventario(string.Empty," ", " ");
             RacionRepositorio RacionRepo = new RacionRepositorio(dbConn);
             UsuarioRepositorio UsuarioRepo = new UsuarioRepositorio(dbConn);
             RacionRepositorio racionRepo = new RacionRepositorio(dbConn);
             RecetaRepositorio recetaRepo = new RecetaRepositorio(dbConn);
             InventarioRepositorio inventarioRepo = new InventarioRepositorio(dbConn);

             Console.WriteLine("------Create");
             UsuarioRepo.Insert(newUsuario);

             Console.WriteLine("------FindAll");
             var all = UsuarioRepo.FindAll(); 

            // all.FirstOrDefault(x => x.UserName = "" && x => x.Password )

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
            */
            Console.WriteLine("Bienvenido a mi inventario");
            int op;
            Interaccion interaccion = new Interaccion();
            Console.WriteLine("seleccione una opción:\n 1.Crear Usuario\n 2.Iniciar sesión\n 3.Eliminar usuario\n 4.Actualización información");
            op = int.Parse(Console.ReadLine());
            interaccion.RegistroLogeo(op);


        }
    }
}