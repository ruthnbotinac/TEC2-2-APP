namespace Application

//Integrantes: Maria de Los Angeles y Alexandra Rey 

{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A GESTIÓN DE COMPRAS");
            Console.WriteLine("Ménu\n Seleccione una opción\n 1.Perfil empresa\n 2.Requisión de compra\n 3.Perfil aprobador\n 4. Perfil comprador");
            int op;
            PerfilEmpresa perfilEmpresa = new PerfilEmpresa();
            Menus menus = new Menus();
            Requisicion requisicion = new Requisicion();
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                menus.PrincipalMenu();
            }
            if (op == 2)
            {
                requisicion.RegistroRequisicion();
            }

        }
    }
}
