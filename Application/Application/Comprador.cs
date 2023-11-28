using Google.Api;

namespace Application
{
    public class Comprador
    {
        private string _id { get; set; }
        private string _nombre { get; set; }
        private int _codigoComprador { get; set; }

        public string Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int CodigoComprador { get { return _codigoComprador; } set { _codigoComprador = value; } }
        //Id 
        public Comprador(string nombre, int idComprador)
        {
            Nombre = nombre;
            CodigoComprador = idComprador;
        }

        public void RealizarCompra(string producto, int cantidad)
        {
            // Desarrollar metodo para generar orden de compra 
            //Brindar  información sobre el estatus del pedido


            Console.WriteLine("El comprador " + Nombre + " ha comprado " + cantidad + " unidades del producto " + producto);

        }

        public void GenerarOrdenCompra(string producto, int cantidad)
        {
            // ID Para la generación de la orden de compra 
            Random random = new Random();
            int serialOrden = random.Next(1000, 10000); // Generar un ID de orden aleatorio
            DateTime fechaOrden = DateTime.Now; // Obtener la fecha y hora actual


            Console.WriteLine("Orden de compra generada para:");
            Console.WriteLine("ID de Orden: " + serialOrden);
            Console.WriteLine("Comprador: " + Nombre);
            Console.WriteLine("Producto: " + producto);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Fecha de Orden: " + fechaOrden);

            Console.WriteLine("La solicitud está siendo procesada...");
        }

    }
}
