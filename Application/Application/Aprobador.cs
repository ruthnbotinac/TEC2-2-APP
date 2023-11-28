using System.Collections;

namespace Application
{
    public class Aprobador
    {
        //propiedades 

        public static int codigoAprobador = 1;
        public String nombreAprobador;
        public String departamento;

        private string _id { get; set; }
        private int _codigoAprobador { get; set; }
        private string _departamento { get; set; }

        public Aprobador()
        {
            
        }

        public string Id { get { return _id; } set { _id  = value; } }
        public int CodigoAprobador { get { return _codigoAprobador; } set { codigoAprobador = value; } }
        public string Departamento{ get { return _departamento; }  set { _departamento = value; }  }

        public Aprobador(string Id, int codigoAprobaador, string departamento )
        {
            
        }

        //encapsulamiento


        public void AprobadorCodigo()

        {
            CodigoAprobador = codigoAprobador++;
        }

        public string NombreAprobador
        {
            get { return nombreAprobador; }
            set
            {
                if (value.Length > 4)
                {
                    nombreAprobador = value;
                }
                else
                {
                    throw new ArgumentException("El nombre del aprobador debe tener más de 4 caracteres");
                }
            }
        }

      
       
      

     
        public void RegistrarAprobador(string nombreAprobador, string departamento)
        {
            NombreAprobador = nombreAprobador;
            Departamento = departamento;
        }
    
        public void ImprimirDatosAprobador()
        {
            Console.WriteLine("ID del Aprobador: " + CodigoAprobador);
            Console.WriteLine("Nombre del Aprobador: " + NombreAprobador);
            Console.WriteLine("Departamento: " + Departamento);

        }

        

    }
}
