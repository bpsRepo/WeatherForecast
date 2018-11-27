using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;

namespace WeatherForecast.DAL
{
    /// <summary>
    /// Class to get data from server in JSON format
    /// </summary>
    public class LiveDataCollector : IDataCollector
    {
        private readonly string _url;

        /// <summary>
        /// Initialize the url from config file
        /// </summary>
        public LiveDataCollector()
        {
            StringBuilder buildedUrl = new StringBuilder();
            buildedUrl.Append(ConfigurationManager.AppSettings["forecastUrl"]);
            buildedUrl.Append("?");
            buildedUrl.Append(ConfigurationManager.AppSettings["budapestID"]);
            buildedUrl.Append("&");
            buildedUrl.Append(ConfigurationManager.AppSettings["appID"]);
            _url = buildedUrl.ToString();
        }

        /// <summary>
        /// Get the data from server
        /// </summary>
        /// <returns>The collected data</returns>
        public string Collect()
        {
            string collectedJSON = string.Empty;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    if (stream != null)
                    {
                        StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                        collectedJSON = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error during try to read and process sample data." + ex.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }

            return collectedJSON;
        }
    }
}

