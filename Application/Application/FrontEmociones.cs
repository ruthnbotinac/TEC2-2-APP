using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class FrontEmociones
    {
        private string _Asco;
        private string _Alegria;
        private string _Tristeza;
        private string _Enojo;
        private string _Miedo;
        private string _Sorpresa;

        public string EmoAsco
        {
            get { return _Asco; }
            set
            {
                if (value == "Asco" || value == "asco")
                {
                    Console.WriteLine("¡Excelente elección!");
                    _Asco = value;
                }
                else
                {
                    throw new Exception("Revisa que hayas escrito correctamente");
                }

                //_Asco = value;
            }

        }
        public string EmoAlegria
        {
            get { return _Alegria; }
            set { _Alegria = value; }
        }

    }
}
