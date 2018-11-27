using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent root object - generated class
    /// </summary>
    public class RootObject
    {
        [JsonProperty(PropertyName = "cod")]
        public string Cod { get; set; }

        [JsonProperty(PropertyName = "message")]
        public double Message { get; set; }

        [JsonProperty(PropertyName = "cnt")]
        public int Cnt { get; set; }

        [JsonProperty(PropertyName = "list")]
        public List<List> List { get; set; }

        [JsonProperty(PropertyName = "city")]
        public City City { get; set; }
    }
}
