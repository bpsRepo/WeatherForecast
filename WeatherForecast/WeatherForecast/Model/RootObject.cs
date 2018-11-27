using System.Collections.Generic;

namespace WeatherForecast.Model
{
    /// <summary>
    /// Represent root object - generated class
    /// </summary>
    public class RootObject
    {
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
        public City city { get; set; }
    }
}
