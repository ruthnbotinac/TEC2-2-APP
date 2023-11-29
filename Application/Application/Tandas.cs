using Application.Data;
using Application.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Tandas
    {
        Interaccion interaccion = new Interaccion();    
        public Tandas() { }

        public void RealizarTandas(string NombreReceta)
        {
            double Multiplicador;
            Conexion dbConn = new Conexion();
            RecetaRepositorio recetaRepo = new RecetaRepositorio(dbConn);
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
            interaccion.MenuPrincipal();
        }

    }
}
