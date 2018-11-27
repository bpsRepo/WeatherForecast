
using Newtonsoft.Json;

namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent clouds - generated class
    /// </summary>
    public class Clouds
    {
        [JsonProperty(PropertyName = "all")]
        public int All { get; set; }
    }
}
