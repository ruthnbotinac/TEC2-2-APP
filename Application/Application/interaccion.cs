using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
   public class interaccion
    {
        
        public void RegistroLogeo (int op)
        {
            Usuario usuario = new Usuario();
            string nombre, contrasena;
            if (op == 1)
            {
                Console.WriteLine("Ingrese su nombre para crear usuartio: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese una contraseña:");
                contrasena = Console.ReadLine();
                usuario.UserName = nombre;
                usuario.Password = contrasena;

                Console.WriteLine($"su usuario es: {usuario.UserName} y su contraseña es: {usuario.Password}");
            }
            if (op == 2)
            {
                Console.WriteLine("Ingrese su Usuario y contraseña");
                Console.WriteLine("Usuario:");
                nombre = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                contrasena = Console.ReadLine();
                usuario.Acceso(nombre, contrasena);
            }
        }
        public static void MenuPrincipal()
        {
            string NombreProducto, justificacion;
            double CantidadProducto, Multiplicador;
            int op;
            Console.WriteLine("Menú principal\n Seleccione una opción\n 1.Ingreso de materia prima\n 2.Ingreso bajas y reprocesos\n 3.Tandas\n 4.Ingrese nueva receta\n 5.Inventario");
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
                Tandas tandas = new Tandas();
                Console.WriteLine("Ingrese el nombre del producto realizado:");
                NombreProducto = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de veces por la cual quiere multiplicar la receta");
                Multiplicador = double.Parse(Console.ReadLine());

                if (Multiplicador <= 0)
                {
                    Console.WriteLine("Cantidad invalida, por favor ingrese un valor positivo mayor a cero");
                }
                else
                {
                    tandas.RealizarTandas(NombreProducto, Multiplicador);
                }
                MenuPrincipal();
            }
            
            if (op == 4)
            {
                Console.WriteLine("Ingrese nueva receta");
                Console.WriteLine("Ingrese le nombre de la receta:");
                string nombreReceta = Console.ReadLine();
                Console.WriteLine("Ingrese el listado de ingredientes con sus respectivos pesos");
                Dictionary<string, double> nuevaReceta = new Dictionary<string, double>();

                while(true)
                {
                    Console.WriteLine("Ingrese el nombre del ingrediente cunado termine digite la palabra fin:");

                    NombreProducto = Console.ReadLine();

                    if (NombreProducto.ToLower() == "fin")
                        break;
                    Console.WriteLine("Ingrese el peso de los ingredientes:");

                    double peso = double.Parse(Console.ReadLine());   

                    if (peso >= 0)
                    {
                        nuevaReceta.Add(NombreProducto, peso);    
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado no es valido");
                    }
                    
                }

                foreach (var kvp in nuevaReceta)
                {
                    Console.WriteLine($"Ingrediente: {kvp.Key}, Peso: {kvp.Value}");
                }

                Console.WriteLine("Ingrese los pasos a seguir. Para finalizar, ingrese ´salir´. ");
                
                Dictionary<int, string> descripcion = new Dictionary<int, string>();

                while(true)
                {
                    Console.WriteLine("Ingrese el número del paso de la receta: ");
                    string llaveInput = Console.ReadLine();

                    if (llaveInput.ToLower() == "salir")
                        break;
                    if (int.TryParse(llaveInput,out int llave))
                    {
                        Console.WriteLine("Ingrese la descripción del paso a seguir: ");
                        string valor = Console.ReadLine();

                        descripcion[llave] = valor;
                    }
                    else
                    {
                        Console.WriteLine("Caracter ingresadonno valido. Debe ser un número entero  ");
                    }
                }

                Console.WriteLine("\nContenido de la descripción de receta: ");

                foreach (var kvp in descripcion)
                {
                    Console.WriteLine($"Paso: {kvp.Key}, Descripción: {kvp.Value}");
                }

                MenuPrincipal();
            }
            if (op == 5)
            {
                Inventario inventario = new Inventario();
                Console.WriteLine("Este es su inventario: ");
                inventario.Mostrarinventario();


                MenuPrincipal();    
            }
        }
    }
}
