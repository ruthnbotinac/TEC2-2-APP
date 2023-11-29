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
            string NombreProducto, NombreReceta;
            
            Inventario inventario = new Inventario();
            Tandas  tandas = new Tandas();
            Receta receta = new Receta();
            
            int op;
            Console.WriteLine("Menú principal\n Seleccione una opción\n 1.Ingreso de materia prima\n 2.Ingreso bajas y reprocesos\n 3.Tandas\n 4.Ingrese nueva receta\n 5.Inventario\n 6.Salir");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("Ingrese el nombre del producto:");
                NombreProducto = Console.ReadLine();
                inventario.AgregarMateriaPrima(NombreProducto);
            }
            if (op == 2)
            {
                Console.WriteLine("Ingrese el nombre del producto:");
                NombreProducto = Console.ReadLine();
                inventario.BajasMateriaPrima(NombreProducto);
            }
            if (op == 3)
            {
                Console.WriteLine("Ingrese el nombre del producto realizado:");
                NombreReceta = Console.ReadLine();
                tandas.RealizarTandas(NombreReceta);    
            }
            if (op == 4)
            {
                Console.WriteLine("Ingrese nueva receta");
                receta.AgregarReceta();
            }
            if (op == 5)
            {
                Console.WriteLine("Este es el listado de los productos que existen en el inventario");
                inventario.MostrarInventario();
            }
            if (op == 6) 
            {
                Console.WriteLine("Cambios guardados con exito...");
            }
        }
    }
}
