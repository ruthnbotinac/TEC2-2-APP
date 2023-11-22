using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Comprador
    {
        public string Nombre { get; set; }
        //Id 
        public Comprador(string nombre)
        {
            Nombre = nombre;
        }

        public void RealizarCompra(string producto, int cantidad)
        {
            // Desarrollar metodo para generar orden de compra 
            //Brindar  información sobre el estatus del pedido

 
            Console.WriteLine("El comprador " + Nombre + " ha comprado " + cantidad + " unidades del producto " + producto);
        }

    }
}
