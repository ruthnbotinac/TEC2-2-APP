namespace Application

//Integrantes: Maria de Los Angeles y Alexandra Rey 

{
    public class Program
    {
        static void Main(string[] args)
        {

            Empleado empleado1 = new Empleado("John Doe", "Ventas", "Cadena A");

            // Acceder a las propiedades del empleado
            Console.WriteLine("Nombre del empleado: " + empleado1.Nombre);
            Console.WriteLine("Departamento: " + empleado1.Departamento);


            Aprobador aprobador1 = new Aprobador(56, "pepito","stewart" );

            // Acceder a las propiedades del aprobador
            Console.WriteLine("ID" + aprobador1.Id);
            Console.WriteLine("Nombre del aprobador: " + aprobador1.Nombre);
            Console.WriteLine("ROL: " + aprobador1.Rol);


            // Crear un DetalleRequisición
            DetalleRequisición detalleRequisición = new DetalleRequisición("Producto1", 5, "MarcaX");

            // Acceder a las propiedades del detalle
            Console.WriteLine("Detalle de la Requisición:");
            Console.WriteLine("Producto: " + detalleRequisición.Producto);
            Console.WriteLine("Cantidad: " + detalleRequisición.Cantidad);
            Console.WriteLine("Marca: " + detalleRequisición.Marca);



        }
   }
}
