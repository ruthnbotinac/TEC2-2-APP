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
            Console.WriteLine("Menú principal\n Seleccione una opción\n 1.Ingreso de materia prima\n 2.Ingreso bajas y reprocesos\n 3.Tandas\n 4.Ingrese nueva receta");
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
            if (op == 4)
            {
                Console.WriteLine("Ingrese nueva receta");
                Console.WriteLine("Ingrese le nombre de la receta:");
                string nombreReceta = Console.ReadLine();
                Console.WriteLine("Ingrese el listado de ingredientes con sus respectivos pesos");
                Dictionary<string, int> nuevaReceta = new Dictionary<string, int>();

                while(true)
                {
                    Console.WriteLine("Ingrese el nombre del ingrediente cunado termine digite la palabra fin:");
                    NombreProducto = Console.ReadLine();
                    if (NombreProducto.ToLower() == "fin")
                        break;
                    Console.WriteLine("Ingrese el peso de los ingredientes:");
                    int peso = int.Parse(Console.ReadLine());   
                    if (peso >= 0){
                        nuevaReceta.Add(NombreProducto, peso);
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado no es valido");
                    }
                    Console.WriteLine($"la receta:{nombreReceta}");
                        foreach (var kvp in  nuevaReceta)
                    {
                        Console.WriteLine($"Ingrediente: {kvp.Key}, gramaje: {kvp.Value} gramos");
                    }
                }

                Console.WriteLine("Ingrese los pasos a seguir");
                Dictionary<int, string> descipcion = new Dictionary<int, string>();

                descipcion.Add(1, "");

                //listado de las reciones
                // pasos a segiur
                // nombre receta

                Receta receta = new Receta();

            }
        }
    }
}
