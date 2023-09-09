using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class interaccion
    {
        public static void RegistroLogeo (int op)
        {
            string nombre, contrasena;
            if (op == 1)
            {
                Console.WriteLine("Ingrese su nombre para crear usuartio: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese una contraseña:");
                contrasena = Console.ReadLine();
                Usuario usuario = new Usuario();
                Usuario.UserName = nombre;
                Usuario.Password = contrasena;

                Console.WriteLine($"su usuario es: {Usuario.UserName} y su contraseña es: {Usuario.Password}");
            }
            if (op == 2)
            {
                Console.WriteLine("Ingrese su Usuario y contraseña");
                Console.WriteLine("Usuario:");
                nombre = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                contrasena = Console.ReadLine();
                Usuario.Acceso(nombre, contrasena);
            }
        }
        public static void MenuPrincipal()
        {
            string NombreProducto, justificacion;
            double CantidadProducto;
            int op;
            Console.WriteLine("Menú principal\n Seleccione una opción\n 1.Ingreso de materia prima\n 2.Ingreso bajas y reprocesos\n 3.Tandas\n 4.Enviar informe");
            op = int.Parse(Console.ReadLine());
            if (op == 1 ) {
                Console.WriteLine("Ingrese el nombre del producto:");
                NombreProducto = Console.ReadLine();
                if (NombreProducto == "piña")
                {
                    Console.WriteLine("Ingrese las unidades de piña:");
                    CantidadProducto = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ingrese el peso en gramos:");
                    CantidadProducto = double.Parse(Console.ReadLine());
                }
                MenuPrincipal();
            }
            if (op == 2)
            {
                Console.WriteLine("Ingrese el nombre del producto:");
                NombreProducto = Console.ReadLine();
                if (NombreProducto == "piña")
                {
                    Console.WriteLine("Ingrese las unidades de piña:");
                    CantidadProducto = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese causa de la baja:");
                    justificacion = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ingrese el peso en gramos:");
                    CantidadProducto = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese causa de la baja:");
                    justificacion = Console.ReadLine();

                }
                MenuPrincipal();
            }
            if (op == 3)
            {
                Console.WriteLine("Ingrese el nombre del producto realizado:");
                NombreProducto = Console.ReadLine();    
            }
        }
    }
}
