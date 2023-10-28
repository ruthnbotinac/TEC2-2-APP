using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Inventario
    {
        public Dictionary<string, double> inventario = new Dictionary<string, double>();
        public void Mostrarinventario()
        {
            inventario["Azúcar"] = 25000;
            inventario["Crema de leche"] = 5000;
            inventario["Huevos"] = 12890;
            inventario["Queso crema"] = 5000;
            inventario["Queso azul"] = 500;
            inventario["Queso paipa"] = 1000;
            inventario["Sal"] = 2500;

            foreach (var kvp in inventario)
            {
                Console.WriteLine($"Ingrediente: {kvp.Key}, Peso: {kvp.Value}");
            }
        }
    public void RestarInventario()
        {
            Receta receta = new Receta();
            foreach (var key in inventario.Keys)
            {
                inventario[key] -= receta.CheesecakeQuesoPaipa[key];
            }

            foreach (var kvp in inventario)
            {
                Console.WriteLine($"Ingrediente: {kvp.Key}, Peso: {kvp.Value}");
            }
        }
    }
}
