namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a mi inventario");
            int op;
            Console.WriteLine("seleccione una opción:\n 1.Crear Usuario\n 2.Iniciar sesión\n 3.Eliminar usuario\n 4.Actualización información");
            Interaccion interaccion = new Interaccion();
            op = int.Parse(Console.ReadLine());
            interaccion.RegistroLogeo(op);
        }
    }
}