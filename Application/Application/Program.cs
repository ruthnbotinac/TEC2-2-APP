namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op;
            string nombre, contrasena;
            Console.WriteLine("Bienvenido a mi inventario");
            Console.WriteLine("seleccione una opción:\n 1.Crear Usuario\n 2.Iniciar sesión");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("Ingrese su nombre para crear usuartio: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese una contraseña:");
                contrasena = Console.ReadLine();
                usuario usuario = new usuario();
                usuario.UserName = nombre;
                usuario.Password = contrasena;

                Console.WriteLine($"su usuario es: {usuario.UserName} y su contraseña es: {usuario.Password}");
            }
            if( op == 2)
            {
                Console.WriteLine("Ingrese su Usuario y contraseña");
                Console.WriteLine("Usuario:");
                nombre = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                contrasena = Console.ReadLine();
                usuario.Acceso(nombre, contrasena);
            }
        }
    }
}