using WeatherForecast.Model;

namespace WeatherForecast.DAL
{
    /// <summary>
    /// Data parser interface
    /// </summary>
    public interface IDataParser
    {
        /// <summary>
        /// Parse data into root object 
        /// </summary>
        /// <param name="collectedData">The collected data</param>
        /// <returns>The deserialized object</returns>
        RootObject ParseWeatherForecastData(string collectedData);
    }
}
