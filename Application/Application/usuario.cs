using Application.Data;
using Application.Data.FireStoreModels;
using Application.Data.Repositorios;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace Application
{
    public class Usuario
    {
        Interaccion interaccion = new Interaccion();
        

        private  string _userName = "BraianRamirez";
        private  string _password = "GETSUGAtenshou";
        private string _id { get; set; }
        public string Id 
        {
            get { return _id; }
            set { _id = value; }
        }
        
        
        public  string UserName
        {
            get { return _userName; }
            set { _userName = value; }
            
        }
        public  string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public void Acceso( string nombre, string contrasena)
        {
            Conexion dbConn = new Conexion();
            UsuarioRepositorio UsuarioRepo = new UsuarioRepositorio(dbConn);
            Console.WriteLine("------FindAll");
            var all1 = UsuarioRepo.FindAll();
            var acceso = all1.FirstOrDefault(x => x.UserName == nombre && x.Password == contrasena);
            if (acceso == null)
            {
                Console.WriteLine("Usuario y contraseña invalidos, intentelo nuevamente");
            }
            else
            {
                Console.WriteLine("Bienvenido " + nombre);
                interaccion.MenuPrincipal();
            }
        }
        public void CrearUsuario( string nombre, string contrasena) 
        {
            Conexion dbConn = new Conexion();
            UsuarioRepositorio UsuarioRepo = new UsuarioRepositorio(dbConn);
            Usuario usuario = new Usuario();
            var all = UsuarioRepo.FindAll();
            usuario.UserName = nombre;
            usuario.Password = contrasena;
            Usuario newUsuario = new Usuario(string.Empty, nombre, contrasena);
            Console.WriteLine("------Create");
            UsuarioRepo.Insert(newUsuario);
            Console.WriteLine($"su usuario es: {usuario.UserName} y su contraseña es: {usuario.Password}");
            int opp = int.Parse(Console.ReadLine());
            interaccion.RegistroLogeo(opp);
        }
        public void BorrarUsuario(string nombre)
        {
            Conexion dbConn = new Conexion();
            UsuarioRepositorio UsuarioRepo = new UsuarioRepositorio(dbConn);
            var all = UsuarioRepo.FindAll();
            var userExist = all.FirstOrDefault(x => x.UserName == nombre);
            if (userExist == null)
            {
                Console.WriteLine("El usuario ingresado no existe en la base de datos.");
            }
            else
            {
                Console.WriteLine("id: " + userExist.Id);
                Console.WriteLine("------Delete");
                string Id = userExist.Id;
                UsuarioRepo.Delete(Id);
            }
        }
        public void ActualizarDatos(string nombre, string contrasena) 
        {
            Conexion dbConn = new Conexion();
            UsuarioRepositorio UsuarioRepo = new UsuarioRepositorio(dbConn);
            var all = UsuarioRepo.FindAll();
            Console.WriteLine("------FindAll");
            var all1 = UsuarioRepo.FindAll();
            var userExist = all1.FirstOrDefault(x => x.UserName == nombre);
            if (userExist == null)
            {
                Console.WriteLine("El usuario ingresado no existe en la base de datos");
            }
            else
            {
                UserName = nombre;
                Password = contrasena;
                Console.WriteLine("-----Update");
                Usuario updateClass = all.Last();
                updateClass.UserName = nombre;
                updateClass.Password = contrasena;
                UsuarioRepo.update(updateClass);
            }
        }

        public Usuario()
        {
                
        }
        public Usuario(string id, string username, string password)
        {
            _password = password;
            _userName = username;
            _id = id;
        }


    }
}
