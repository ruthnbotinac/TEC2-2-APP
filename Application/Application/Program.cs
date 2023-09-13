namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido");
            Console.WriteLine("Elija la opcion que desea");
            Console.WriteLine("(1) Figuras Plana");
            Console.WriteLine("(2)");
            Console.WriteLine("_______________________________\n");

            string opc;
            opc = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("La opcion elegida es" + ":" + opc);

            Console.WriteLine("_______________________________\n");
            Console.WriteLine("Figuras Planas\n");
            Console.WriteLine("");
            Console.WriteLine("Eliga una de las opciones de las cuales quiere hallar el Area\n");

            Console.WriteLine("1" + " : " + "Area Cuadrado");
            Console.WriteLine("2" + " : " + "Area Rectangulo");
            Console.WriteLine("3" + " : " + "Area Triangulo\n");

            Console.WriteLine("_______________________________\n");

            switch (opc)
            {
                case "1":
                    FigurasPlanas.ExecuteExercise();
                    break;


            }
        }

    }
}