using System.Collections;

namespace Application
{
    public class Requisicion

    {

        PerfilEmpresa perfilEmpresa = new PerfilEmpresa();
        List<Requisicion> listaRequisiciones = new List<Requisicion>();

        public int contador = 0;
        public double Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }

        public string UnidadDeMedida { get; set; }
        public int IdSolicitante { get; set; 
        }



        public void RegistroRequisicion()
        {

            {

                {

                    Console.WriteLine("Ingrese el Id del solicitante:");
                    IdSolicitante = int.Parse(Console.ReadLine());

                    int cid = perfilEmpresa.contadorIdSolicitante;

                    if (IdSolicitante == cid)
                    {
                        Console.WriteLine("Usuario encontrado");
                    }

                    Console.WriteLine("Ingrese los datos de la requisición:");

                    DateTime fecha = DateTime.Now;
                    string producto, unidadDeMedida;
                    double cantidad;

                    Console.WriteLine("Producto: ");

                    producto = Console.ReadLine();
                    Console.WriteLine("Cantidad: ");

                    cantidad = double.Parse(Console.ReadLine());

                    Console.WriteLine("Indique la unidad de medida: ");

                    unidadDeMedida = Console.ReadLine();


                    GenerarRequisicion(fecha, producto, cantidad, unidadDeMedida);

                    GenerarSerial();
                }

            }
        }

        public void GenerarRequisicion(DateTime fecha, string producto, double cantidad, string unidadDeMedida)
        {
            Requisicion nuevaRequisicion = new Requisicion
            {
                Fecha = fecha,
                Producto = producto,
                Cantidad = cantidad,
                UnidadDeMedida = unidadDeMedida
            };

            listaRequisiciones.Add(nuevaRequisicion);
        }

        public void ImprimirRegistros()
       {
            Console.WriteLine("Listado de Requisiciones:");
            int serial = 1;
            

            foreach (var requisicion in listaRequisiciones)
            {
                Console.WriteLine($"Serial: {serial++}, ID del Solicitante: {requisicion.IdSolicitante}, Fecha: {requisicion.Fecha.ToString("dd/MM/yyyy HH:mm:ss")}, Producto: {requisicion.Producto}, Cantidad: {requisicion.Cantidad}, Unidad de Medida: {requisicion.UnidadDeMedida}");
            }
        }




        public void GenerarSerial()
        {

            contador++;
            Console.WriteLine("Serial: " + contador);


        }


    }
}
