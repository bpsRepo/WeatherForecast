namespace WeatherForecast.DAL
{
    /// <summary>
    /// Data collector interface
    /// </summary>
    public interface IDataCollector
    {
        /// <summary>
        /// Get the data from server
        /// </summary>
        /// <returns>The collected data</returns>
        string Collect();
    }
}
