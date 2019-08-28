using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolaMundo.Modelos
{
    public class PeliculasCons
    {
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
        [JsonProperty(PropertyName = "next")]
        public object Next { get; set; }
        [JsonProperty(PropertyName = "previous")]
        public object Previous { get; set; }

        [JsonProperty(PropertyName = "results")]
        public List<Pelicula> Results { get; set; }
    }
}
