using System.Text;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool flag = true;
            int amount = 0;

            Console.WriteLine("Bienvenido a tu alcancía...");

            Console.WriteLine();

            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("1. Ingresar dinero");
                Console.WriteLine("2. Sacar dinero");
                Console.WriteLine("3. Salir...");
                Console.Write("Selecciona una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        amount = addMount(amount);
                        break;

                    case 2:
                        amount = removeMount(amount);
                        break;

                    case 3:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                        break;
                }

                Console.WriteLine();
                Console.Write("La cantidad actual es -> ");
                Console.Write(amount);
                Console.WriteLine();
            }
        }

        static int addMount(int amount)
        {
            Console.WriteLine("Ingresa la cantidad a ingresar...");
            int value = Convert.ToInt32(Console.ReadLine());
            return value + amount;
        }

        static int removeMount(int amount)
        {
            Console.WriteLine("Ingresa la cantidad a retirar...");
            int value = Convert.ToInt32(Console.ReadLine());
            return amount - value;
        }

    }
}
