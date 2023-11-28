namespace Application
{
    public class Solicitante
    {


      
        private string _nombre { get; set; }
        private int _codigoSolicitante { get; set; }
        private string _id { get; set; } 

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int CodigoSolicitante { get { return _codigoSolicitante; } set { _codigoSolicitante = value; } }

        public string Id { get { return _id; } set { _id = value; } }

        public Solicitante(string nombre, int codigoSolicitante, int id)
        {
            _nombre = nombre;
            _codigoSolicitante = codigoSolicitante;
            _id = id;
        }
    }
}