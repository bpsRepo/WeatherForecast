
using Newtonsoft.Json;

namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent sys - generated class
    /// </summary>
    public class Sys
    {
        [JsonProperty(PropertyName = "pod")]
        public string Pod { get; set; }
    }
}
