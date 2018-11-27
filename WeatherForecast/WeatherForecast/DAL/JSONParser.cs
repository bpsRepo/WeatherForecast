using Newtonsoft.Json;
using System;
using WeatherForecast.Model;

namespace WeatherForecast.DAL
{
    /// <summary>
    /// JSON Parser class
    /// </summary>
    public class JSONParser : IDataParser
    {
        /// <summary>
        /// Deserialize JSON formatted data into object 
        /// </summary>
        /// <param name="collectedJSON">The collected JSON formatted data</param>
        /// <returns>The deserialized object</returns>
        public RootObject ParseWeatherForecastData(string collectedJSON)
        {
            try
            {
                return JsonConvert.DeserializeObject<RootObject>(collectedJSON);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Data deserialization was not success." + ex.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                return null;
            }
        }
    }
}
