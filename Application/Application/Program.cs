namespace Application

//Integrantes: Maria de Los Angeles y Alexandra Rey 

{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A GESTIÓN DE COMPRAS");
            int op;
            PerfilEmpresa perfilEmpresa = new PerfilEmpresa();
            Menus menus = new Menus();
            Requisicion requisicion = new Requisicion();
            Aprobador aprobador = new Aprobador();
            // Comprador comprador = new Comprador();

            do
            {
                Console.WriteLine("\nMénu\nSeleccione una opción\n1.Perfil empresa\n2.Requisición de compra\n3.Perfil aprobador\n4.Perfil comprador\n5.Salir");

                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        menus.PrincipalMenu();
                        break;
                    case 2:
                        menus.menuRequisicion();
                        break;
                    case 3:
                        menus.menuAprobador();
                        break;
                    case 4:
                        menus.menuComprador();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (op != 5);
        }
    }
}
