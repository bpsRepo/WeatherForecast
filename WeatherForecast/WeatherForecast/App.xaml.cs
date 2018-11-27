using System;
using System.Configuration;
using System.Windows;
using Unity;
using WeatherForecast.DAL;
using WeatherForecast.View;

namespace WeatherForecast
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            try
            {

                UnityContainer objectContainer = new UnityContainer();

                Type actualDataCollector = Type.GetType(ConfigurationManager.AppSettings["ActualDataCollector"]);

                Type iDataCollector = Type.GetType(ConfigurationManager.AppSettings["IDataCollector"]);

                objectContainer.RegisterType(iDataCollector, actualDataCollector, string.Empty, null);

                objectContainer.RegisterType<IDataParser, JSONParser>();

                WeatherForecastView weatherForecastView = objectContainer.Resolve<WeatherForecastView>();
                weatherForecastView.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Application chrased." + ex.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }
    }
}
