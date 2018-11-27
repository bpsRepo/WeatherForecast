
using Newtonsoft.Json;

namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent main data - generated class
    /// </summary>
    public class Main
    {
        [JsonProperty(PropertyName = "temp")]
        public double Temp { get; set; }

        [JsonProperty(PropertyName = "temp_min")]
        public double Temp_min { get; set; }

        [JsonProperty(PropertyName = "temp_max")]
        public double Temp_max { get; set; }

        [JsonProperty(PropertyName = "pressure")]
        public double Pressure { get; set; }

        [JsonProperty(PropertyName = "sea_level")]
        public double Sea_level { get; set; }

        [JsonProperty(PropertyName = "grnd_level")]
        public double Grnd_level { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public int Humidity { get; set; }

        [JsonProperty(PropertyName = "temp_kf")]
        public double Temp_kf { get; set; }
    }
}
