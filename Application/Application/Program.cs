using System.Reflection.Metadata;
//Brenda Vargas Parra - 614222713 & Viviana Garcia Valderrama - 506222720


namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Usuario firstUser = new Usuario();

            firstUser.FirstName = string.Empty;
            firstUser.LastName = string.Empty;
           
            firstUser.Age = Console.Read();

            Console.WriteLine(firstUser.FirstName);


            
        }
    }
}