namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op;
            
            Console.WriteLine("Bienvenido a mi inventario");
            Console.WriteLine("seleccione una opción:\n 1.Crear Usuario\n 2.Iniciar sesión");
            op = int.Parse(Console.ReadLine());
            interaccion.RegistroLogeo(op);
           
        }
    }
}