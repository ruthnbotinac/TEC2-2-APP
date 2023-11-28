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
            Console.WriteLine("seleccione una opción:\n 1.Crear Usuario\n 2.Iniciar sesión\n 3.Eliminar usuario\n 4.Actualización información");
            Conexion dbConn = new Conexion();
            UsuarioRepositorio UsuarioRepo = new UsuarioRepositorio(dbConn);
            Usuario usuario = new Usuario();
            var all = UsuarioRepo.FindAll();
            string nombre, contrasena, UserName;
            int opp;

            if (op == 1)
            {
                Console.WriteLine("Ingrese su nombre para crear usuario: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese una contraseña:");
                contrasena = Console.ReadLine();
                usuario.CrearUsuario(nombre, contrasena);
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
                Console.WriteLine("escriba el nombre del usuario que desea eliminar:");
                nombre= Console.ReadLine();
                usuario.BorrarUsuario(nombre);
            }
            if (op == 4)
            {
                Console.WriteLine("Ingrese su usuario para actualizar sus datos: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su nueva contraseña:");
                contrasena = Console.ReadLine();
                usuario.ActualizarDatos(nombre, contrasena); 
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

                        Console.Write("la cantidad de ingredientes usada es de: " + result + " " + item.UnidadMedida + " " + item.Producto);
                        Console.WriteLine(" ");
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
                Console.WriteLine("Ingrese la cantidad de productos que desea agregar:");

                if (!int.TryParse(Console.ReadLine(), out int cantidadProductos) || cantidadProductos <= 0)
                {
                    Console.WriteLine("Cantidad inválida. Debe ingresar un número mayor que cero.");
                    return;
                }

                int contador = 0;

                while (contador < cantidadProductos)
                {
                    Console.WriteLine($"\nProducto {contador + 1}:");
                    Console.Write("Nombre: ");
                    string nombreProducto = Console.ReadLine();

                    Console.Write("Cantidad: ");
                    if (!double.TryParse(Console.ReadLine(), out double cantidad))
                    {
                        Console.WriteLine("Cantidad inválida. Intente nuevamente.");
                        continue;
                    }

                    Console.Write("Unidad de Medida: ");
                    string unidadMedida = Console.ReadLine();

                    Racion nuevaRacion = new Racion
                    {
                        Producto = nombreProducto,
                        Peso = cantidad,
                        UnidadMedida = unidadMedida
                    };

                    listaRaciones.Add(nuevaRacion);
                    contador++;
                }
                string descripcion;
                Console.WriteLine("Agrege el paso a paso de la receta: ");
                descripcion = Console.ReadLine();


                Receta newReceta = new Receta(string.Empty, nombreReceta, listaRaciones, descripcion);
                Console.WriteLine("------Create");
                recetaRepo.Insert(newReceta);
                MenuPrincipal();

            }
            if (op == 5)
            {
                Console.WriteLine("------FindAll");
                var all = inventarioRepo.FindAll();
                Console.WriteLine(all);
                MenuPrincipal();
            }
        }
    }
}
