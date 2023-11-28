using System.Collections;

namespace Application
{
    public class Menus
    {
        PerfilEmpresa perfilEmpresa = new PerfilEmpresa();
        Requisicion requisicion = new Requisicion();
        Aprobador aprobador = new Aprobador();
        public int contador = 0000;



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

        public void menuRequisicion()
        {
            Console.WriteLine("Por favor ingrese su solicitud");
            requisicion.RegistroRequisicion();
        }


        public void menuAprobador()
        {
            Console.WriteLine("Seleccione una opción\n 1. Ver requisiciones \n 2. Aprobación de requisiciones\n ");
            int op;

            op = int.Parse(Console.ReadLine());


            if (op == 1)
            {

                Console.WriteLine("La requisiones actuales son: ");

                requisicion.ImprimirRegistros();



            }

            if (op == 2)
            {

                Console.WriteLine("Ingrese el número de serial que sea aprobar");

                int serialIngresado = int.Parse(Console.ReadLine());
                // requisicion.GenerarSerial();
            }



            //lista requisiones
            //selección por serial
            //up date (APROBADO) / (RECHAZAR)

        }

        public void menuComprador()
        {
            //lista requisiones aprobadas 

            //tener metodo de generar orden de compra y hacer seguimiento en curso o finalizado 
            Console.WriteLine("Seleccione una opción\n 1. Ver requisiciones aprobadas   \n 2. Generar orden de compra\n 3. Seguimiento de orden de compra\n ");
            int op;

            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                //MostrarRequisicionesAprobadas(); // Método para mostrar las requisiciones aprobadas
            }
            else if (op == 2)
            {
                // GenerarOrdenCompra(); // Método para generar una orden de compra
            }
            else if (op == 3)
            {
                // SeguimientoOrdenCompra(); // Método para hacer seguimiento de una orden de compra
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }


        }


    }


}





