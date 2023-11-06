using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class MusicInfo
    {
        public string Autor { get; set; }
        public string Género { get; set; }
        public string Álbum { get; set; }
        [JsonProperty("URL de la Imagen del Álbum")]
        public string URL_de_la_Imagen_del_Álbum { get; set; }
        [JsonProperty("URL de la Imagen del Artista")]
        public string URL_de_la_Imagen_del_Artista { get; set; }
        [JsonProperty("URL del Video")]
        public string URL_del_Video { get; set; }
    }
}
