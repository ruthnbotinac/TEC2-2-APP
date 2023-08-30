namespace Application

    //Integrantes: Maria de Los Angeles y Alexandra Rey 
    
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa requisión de compra");
            Console.WriteLine("Por favor ingrese su primer nombre");
            Usuario firsUser = new Usuario();
            firsUser.FirstName = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su Apellido");
        }
    }
}