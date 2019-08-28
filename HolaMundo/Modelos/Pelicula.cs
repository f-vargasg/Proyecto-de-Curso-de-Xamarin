using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolaMundo.Modelos
{
    public class Pelicula
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "episode_id")]
        public int Episode_id { get; set; }
        public string Opening_crawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Release_date { get; set; }
        public List<string> Characters { get; set; }
        public List<string> Planets { get; set; }
        public List<string> Starships { get; set; }
        public List<object> Vehicles { get; set; }
        public List<string> Species { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }

    }
}
