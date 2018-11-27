
using Newtonsoft.Json;

namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent coordinates - generated class
    /// </summary>
    public class Coord
    {
        [JsonProperty(PropertyName = "lat")]
        public double Lat { get; set; }

        [JsonProperty(PropertyName = "lon")]
        public double Lon { get; set; }
    }
}
