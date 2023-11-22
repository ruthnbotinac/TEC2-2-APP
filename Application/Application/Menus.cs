using System.Collections;

namespace Application
{
    public class Menus
    {
        PerfilEmpresa perfilEmpresa = new PerfilEmpresa();
        Requisicion requisicion = new Requisicion();
       //Aprobador aprobador = new Aprobador();
        //Comprador comprador = new Comprador(); 
        

        public void ImprimirArrayLists()
        {
            ArrayList departamentos = perfilEmpresa.GetDepartamentos();
            ArrayList aprobadores = perfilEmpresa.GetAprobadores();
            ArrayList compradores = perfilEmpresa.GetCompradores();
            ArrayList solicitantes = perfilEmpresa.GetSolicitantes();

            // Imprimir los ArrayLists
            foreach (string departamento in departamentos)
            {
                Console.WriteLine(departamento);
            }

            foreach (string aprobador in aprobadores)
            {
                Console.WriteLine(aprobador);
            }

            foreach (string comprador in compradores)
            {
                Console.WriteLine(comprador);
            }

            foreach (string solicitante in solicitantes)
            {
                Console.WriteLine(solicitante);
            }
        }


        public void PrincipalMenu()
        {
            Console.WriteLine("Seleccione una opción\n 1. Registro aprobador\n 2. Registro comprador\n 3. Registro solicitante");
            int op;
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Por favor registre el nombre del aprobador: ");
                string nombreAprobador = Console.ReadLine();
                Console.WriteLine("Por favor ingrese el nombre del departamento encargado: ");
                string departamento = Console.ReadLine();
                perfilEmpresa.RegistrarAprobador(nombreAprobador, departamento);
            }
            else if (op == 2)
            {
                Console.WriteLine("Por favor registre el nombre del comprador");
                string nombreComprador = Console.ReadLine();
                perfilEmpresa.RegistraComprador(nombreComprador);
            }

            else if (op == 3)
            {
                Console.WriteLine("Por favor ingrese nombre del solicitante");
                string nombreSolicitante = Console.ReadLine();
                perfilEmpresa.RegistroSolicitante(nombreSolicitante);
            }


            else
            {
                Console.WriteLine("Opción no válida");
            }

        }
        public void menuRequision()

        {
            Console.WriteLine("Seleccione una opción\n 1. Registro requisición\n 2. Generar requisión\n 3. Nuevo menú");

            int op;
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                requisicion.RegistroRequisicion();
             
            }

            if (op == 2)
            {

                //aprobador.RegistrarAprobador();
            }

            else
            {
                Console.WriteLine("Opción no válida");
            }

        }
    }


}


