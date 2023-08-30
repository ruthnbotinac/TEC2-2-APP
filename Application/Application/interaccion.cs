using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class interaccion
    {
        public static void MenuPrincipal()
        {
            int op;
            Console.WriteLine("Menú principal\n Seleccione una opción\n 1.Ingreso de materia prima\n 2.Ingreso bajas y reprocesos\n 3. Tandas\n 4. Enviar informe");
            op = int.Parse(Console.ReadLine());
            if (op == 1 ) {
                Console.WriteLine("Ingrese el nombre del producto:");
                string NombreProducto = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad:");
                double CantidadProducto = double.Parse(Console.ReadLine());
            }
        }
    }
}
