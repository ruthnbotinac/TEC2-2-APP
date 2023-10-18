using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Tandas
    {
        public Tandas() { }
        Receta receta = new Receta();
        public void RealizarTandas(string NombreProducto, double Multiplicador)
        {
            if ( NombreProducto == "Cheesecake Queso Paipa")
            {
               foreach (var key in receta.CheesecakeQuesoPaipa.Keys)
                {
                    receta.CheesecakeQuesoPaipa[key] *= Multiplicador; ;
                }

                Console.WriteLine("\nLa cantidad empleada de ingredientes para realizar la receta" + Multiplicador + "veces es:");

                foreach ( var kvp in receta.CheesecakeQuesoPaipa) 
                {
                    Console.WriteLine($"Ingrediente: {kvp.Key}, Peso: {kvp.Value}");
                }

            }
        }
    }
}
