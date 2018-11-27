
namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent city - generated class
    /// </summary>
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
    }
}
