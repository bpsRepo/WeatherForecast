using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent list - generated class
    /// </summary>
    public class List
    {
        [JsonProperty(PropertyName = "dt")]
        public int Dt { get; set; }

        [JsonProperty(PropertyName = "main")]
        public Main Main { get; set; }

        [JsonProperty(PropertyName = "weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty(PropertyName = "clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty(PropertyName = "wind")]
        public Wind Wind { get; set; }

        [JsonProperty(PropertyName = "snow")]
        public Snow Snow { get; set; }

        [JsonProperty(PropertyName = "sys")]
        public Sys Sys { get; set; }

        [JsonProperty(PropertyName = "dt_txt")]
        public string Dt_txt { get; set; }
    }
}
