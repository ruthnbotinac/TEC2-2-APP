using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class PerfilEmpresa
    {
        ArrayList departamentos = new ArrayList();
        ArrayList aprobadores = new ArrayList();
        ArrayList compradores = new ArrayList();
        ArrayList solicitantes = new ArrayList();

        public void RegistrarAprobador(string nombreAprobador, string departamento)
        {
            departamentos.Add(departamento);
            aprobadores.Add(nombreAprobador);

            Console.WriteLine("Aprobador registrado con exito..." + nombreAprobador + " encargado del dpto... " + departamento);
           
        }
        public void RegistraComprador(string nombreComprador)
        {
            compradores.Add(nombreComprador);
            Console.WriteLine("Comprador registrado con exito..." + nombreComprador);
        }

        public void RegistroSolicitante(string nombreSolicitante)

        {
            solicitantes.Add(nombreSolicitante);
            Console.WriteLine("Por favor ingrese el nombre de quien solicita");
        }

        public ArrayList GetDepartamentos()
        {
            return departamentos;
        }
        public ArrayList GetAprobadores()
        {
            return aprobadores;
        }
        public ArrayList GetCompradores()
        {
            return compradores;
        }
        public ArrayList GetSolicitantes()
        {
            return solicitantes;
        }
    }
}
