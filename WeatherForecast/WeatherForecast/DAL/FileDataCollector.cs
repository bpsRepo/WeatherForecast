using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;

namespace WeatherForecast.DAL
{
    /// <summary>
    /// Class to get data from file
    /// </summary>
    public class FileDataCollector : IDataCollector
    {
        private readonly string _fileName;

        /// <summary>
        /// Initialize the url from config file
        /// </summary>
        public FileDataCollector()
        {
            _fileName = ConfigurationManager.AppSettings["samplaDataFileName"];
        }

        /// <summary>
        /// Get data from file
        /// </summary>
        /// <returns>The collected data</returns>
        public string Collect()
        {
            string collectedJSON = string.Empty;

            try
            {
                if (File.Exists(_fileName))
                {
                    collectedJSON = File.ReadAllText(_fileName);
                }
                else
                {
                    System.Windows.MessageBox.Show("Sample file is missing.", "Warning", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error during try to read sample data from file." + ex.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }

            return collectedJSON;
        }
    }
}

