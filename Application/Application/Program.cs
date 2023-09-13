namespace Application

    //Integrantes: Maria de Los Angeles y Alexandra Rey 
    
{
    public class Program
    {
        static void Main(string[] args)
        {

            Empleado empleado1 = new Empleado("John Doe", "Ventas", "Cadena A");

            // Acceder a las propiedades del empleado
            Console.WriteLine("Nombre del empleado: " + empleado1.Nombre);
            Console.WriteLine("Departamento: " + empleado1.Departamento);
            Console.WriteLine("Cadena: " + empleado1.Cadena);
        }

    }
}