
namespace Application
{
    public class InteraccionUsuario
    {
        private FrontEmociones frontEmociones;
        private EleccionArtista eleccionArtista;

        public InteraccionUsuario(FrontEmociones frontEmociones, EleccionArtista eleccionArtista)
        {
            this.frontEmociones = frontEmociones;
            this.eleccionArtista = eleccionArtista;
        }

        public void InteractuarConUsuario()
        {
            Emocion emocionSeleccionada = frontEmociones.SeleccionarEmocion();

            bool continuar = true;

            while (continuar)
            {
                var canciones = emocionSeleccionada.ObtenerCanciones();

                if (canciones.Count == 0)
                {
                    Console.WriteLine($"No se encontraron canciones para la emoción '{emocionSeleccionada.Nombre}'.");
                    return;
                }

                eleccionArtista.MostrarArtistas(canciones);

                Console.Write("Elija un artista ingresando el número correspondiente: ");
                int opcion;

                if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 1 && opcion <= canciones.Count)
                {
                    eleccionArtista.MostrarInformacionCancion(canciones[opcion - 1]);
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                }
            }
        }
    }
}
