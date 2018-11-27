using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WeatherForecast.DAL;
using WeatherForecast.View;
using WeatherForecast.ViewModel;

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
                WeatherForecastVM weatherForecastVM = new WeatherForecastVM();

                WeatherForecastView weatherForecastView = new WeatherForecastView(weatherForecastVM);
                weatherForecastView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Application chrased." + ex.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }
    }
}
