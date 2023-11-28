namespace Application
{
    public class PerfilEmpresa
    {
        public List<string> departamentos = new List<string>();
        public List<string> aprobadores = new List<string>();
        public List<string> compradores = new List<string>();
        public List<Solicitante> solicitantes = new List<Solicitante>();
        public int contadorIdSolicitante = 1;

        public void RegistrarAprobador(string nombreAprobador, string departamento)
        {
            departamentos.Add(departamento);
            aprobadores.Add(nombreAprobador);

            Console.WriteLine("Aprobador registrado con éxito: " + nombreAprobador + " encargado del departamento: " + departamento);
        }

        public void RegistraComprador(string nombreComprador)
        {
            compradores.Add(nombreComprador);
            Console.WriteLine("Comprador registrado con éxito: " + nombreComprador);
        }

        public void RegistroSolicitante(string nombreSolicitante)
        {
            Solicitante nuevoSolicitante = new Solicitante(nombreSolicitante, contadorIdSolicitante);
            solicitantes.Add(nuevoSolicitante);

            Console.WriteLine("Solicitante registrado con éxito: " + nombreSolicitante + ", ID: " + contadorIdSolicitante);

            contadorIdSolicitante++;
        }

        public List<Solicitante> GetSolicitantes()
        {
            return solicitantes;
        }

        public List<string> GetDepartamentos()
        {
            return departamentos;
        }

        public List<string> GetAprobadores()
        {
            return aprobadores;
        }

        public List<string> GetCompradores()
        {
            return compradores;
        }
    }
}
