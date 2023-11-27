using Application.Data;
using Application.Data.Repositorios;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace Application
{
    public class Interaccion
    {

        public void RegistroLogeo(int op)
        {
            Conexion dbConn = new Conexion();
            UsuarioRepositorio UsuarioRepo = new UsuarioRepositorio(dbConn);
            Usuario usuario = new Usuario();
            var all = UsuarioRepo.FindAll();
            string nombre, contrasena;
            int opp;
            if (op == 1)
            {
                Console.WriteLine("Ingrese su nombre para crear usuario: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese una contraseña:");
                contrasena = Console.ReadLine();
                usuario.UserName = nombre;
                usuario.Password = contrasena;
                Usuario newUsuario = new Usuario(string.Empty, nombre, contrasena);
                Console.WriteLine("------Create");
                UsuarioRepo.Insert(newUsuario);

                Console.WriteLine($"su usuario es: {usuario.UserName} y su contraseña es: {usuario.Password}");
                opp = int.Parse(Console.ReadLine());
                RegistroLogeo(opp);

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
            if (op == 3)
            {
                Console.WriteLine("------Delete");
                UsuarioRepo.Delete(all.First().Id);
            }
            if (op == 4)
            {
                Console.WriteLine("Ingrese su nombre para actualizar su usuario: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su nueva contraseña:");
                contrasena = Console.ReadLine();
                usuario.UserName = nombre;
                usuario.Password = contrasena;
                Console.WriteLine("-----Update");
                Usuario updateClass = all.Last();
                updateClass.UserName = nombre;
                updateClass.Password = contrasena;
                UsuarioRepo.update(updateClass);
            }
        }
        public void MenuPrincipal()
        {
            string NombreProducto, justificacion, UnidadMedida, NombreReceta;
            double CantidadProducto, Multiplicador, Peso;
            Conexion dbConn = new Conexion();
            InventarioRepositorio inventarioRepo = new InventarioRepositorio(dbConn);
            RecetaRepositorio recetaRepo = new RecetaRepositorio(dbConn);
            int op;
            Console.WriteLine("Menú principal\n Seleccione una opción\n 1.Ingreso de materia prima\n 2.Ingreso bajas y reprocesos\n 3.Tandas\n 4.Ingrese nueva receta\n 5.Inventario");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("------FindAll");
                var all = inventarioRepo.FindAll();
                Console.WriteLine("Ingrese el nombre del producto:");
                NombreProducto = Console.ReadLine();
                var productExist = all.FirstOrDefault(x => x.Producto == NombreProducto);
                if (productExist == null)
                {
                    Console.WriteLine("Ingrese el peso o la cantidad del producto:");
                    Peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la unidad de medida:");
                    UnidadMedida = Console.ReadLine();
                    Inventario newInventario = new Inventario(string.Empty,NombreProducto, Peso, UnidadMedida);
                    Console.WriteLine("------Create");
                    inventarioRepo.Insert(newInventario);
                }
                else
                {
                    Console.WriteLine("El producto ya existe en el inventario, actualize peso/cantidad");
                    Console.WriteLine("-----Update");
                    //Inventario updateInventario = all.Last();
                    Console.WriteLine("Ingrese el peso o la cantidad del producto:");
                    Peso = double.Parse(Console.ReadLine());
                    productExist.Peso = Peso;
                    inventarioRepo.update(productExist);
                }

                MenuPrincipal();
            }
            if (op == 2)
            {
                Console.WriteLine("------FindAll");
                var all = inventarioRepo.FindAll();
                Console.WriteLine("Ingrese el nombre del producto:");
                NombreProducto = Console.ReadLine();
                var productExist = all.FirstOrDefault(x => x.Producto == NombreProducto);
                if (productExist == null)
                {
                    Console.WriteLine("El producto ingresado no existe en el inventario.");

                }
                else
                {
                    Console.WriteLine("El producto encontrado, ingrese la nueva cantidad/peso");
                    Console.WriteLine("-----Update");
                    //Inventario updateInventario = all.Last();
                    Console.WriteLine("Ingrese el peso o la cantidad del producto:");
                    Peso = double.Parse(Console.ReadLine());
                    productExist.Peso = Peso;
                    inventarioRepo.update(productExist);

                }
                MenuPrincipal();
            }
            if (op == 3)
            {
                Tandas tandas = new Tandas();
                Console.WriteLine("Ingrese el nombre del producto realizado:");
                NombreReceta = Console.ReadLine();
                Console.WriteLine("------FindAll");
                var all = recetaRepo.FindAll();
                var recetaExist = all.FirstOrDefault(x => x.NombreReceta == NombreReceta);
                if (recetaExist == null)
                {
                    Console.WriteLine("Receta no encontrada");
                }
                else
                {
                    Console.WriteLine("Ingrese la cantidad de veces por la cual quiere multiplicar la receta");
                    Multiplicador = double.Parse(Console.ReadLine());

                    foreach (var item in recetaExist.Raciones)
                    {
                        var result = item.Peso * Multiplicador;

                        Console.Write(result);
                    }
                }
                MenuPrincipal();
            }
            if (op == 4)
            {
                Console.WriteLine("Ingrese nueva receta");
                Console.WriteLine("Ingrese le nombre de la receta:");
                string nombreReceta = Console.ReadLine();
                Console.WriteLine("Ingrese el listado de ingredientes con sus respectivos pesos y unidad de medida");
                List<Racion> listaRaciones = new List<Racion>();
                Console.WriteLine("Ingrese las raciones (para salir, escriba 'salir'):");
                while (true)
                {
                    Console.Write("Producto: ");
                    string producto = Console.ReadLine();

                    if (producto.ToLower() == "salir")
                    {
                        break;
                    }

                    Console.Write("Cantidad: ");
                    if (!double.TryParse(Console.ReadLine(), out double cantidad))
                    {
                        Console.WriteLine("Cantidad inválida. Intente nuevamente.");
                        continue;
                    }

                    Console.Write("Unidad de Medida: ");
                    string unidadMedida = Console.ReadLine();

                    // Crear una nueva instancia de Racion y agregarla a la lista
                    Racion nuevaRacion = new Racion
                    {
                        Producto = producto,
                        Peso = cantidad,
                        UnidadMedida = unidadMedida
                    };

                    listaRaciones.Add(nuevaRacion);

                    Dictionary<int, string> descripcion = new Dictionary<int, string>();

                    Console.WriteLine("Ingrese el paso a paso de la receta (para salir, escriba 'salir'):");

                    while (true)
                    {
                        Console.Write("Ingrese el numero del paso: ");
                        string inputKey = Console.ReadLine();

                        if (inputKey.ToLower() == "salir")
                        {
                            break;
                        }

                        if (!int.TryParse(inputKey, out int key))
                        {
                            Console.WriteLine("Llave inválida. Intente nuevamente.");
                            continue;
                        }

                        Console.Write("Ingrese la descripción del paso : ");
                        string value = Console.ReadLine();

                        // Verificar si la llave ya existe en el diccionario
                        if (descripcion.ContainsKey(key))
                        {
                            Console.WriteLine("La llave ya existe en el diccionario. Intente con una llave diferente.");
                            continue;
                        }

                        // Agregar el par llave-valor al diccionario
                        descripcion.Add(key, value);
                    }

                    // Mostrar el diccionario ingresado
                    Console.WriteLine("\nDiccionario ingresado:");
                    foreach (var kvp in descripcion)
                    {
                        Console.WriteLine($"Llave: {kvp.Key}, Valor: {kvp.Value}");
                    }
                    // Mostrar las raciones ingresadas
                    Console.WriteLine("\nRaciones ingresadas:");
                    foreach (var racion in listaRaciones)
                    {
                        Console.WriteLine($"Producto: {racion.Producto}, Cantidad: {racion.Peso}, Unidad de Medida: {racion.UnidadMedida}");
                    }

                    Receta newReceta = new Receta(string.Empty, nombreReceta, listaRaciones, descripcion);
                    Console.WriteLine("------Create");
                    recetaRepo.Insert(newReceta);
                    MenuPrincipal();
                }
                if (op == 5)
                {
                    Inventario inventario = new Inventario();
                    Console.WriteLine("Este es su inventario: ");
                    MenuPrincipal();
                }
            }
        }
    }
}
