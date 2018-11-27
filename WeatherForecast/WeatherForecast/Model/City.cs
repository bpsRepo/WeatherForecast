using Newtonsoft.Json;

namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent city - generated class
    /// </summary>
    public class City
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "coord")]
        public Coord Coord { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
    }
}
