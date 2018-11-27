
using Newtonsoft.Json;

namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent wind - generated class
    /// </summary>
    public class Wind
    {
        [JsonProperty(PropertyName = "speed")]
        public double Speed { get; set; }

        [JsonProperty(PropertyName = "deg")]
        public double Deg { get; set; }
    }
}
