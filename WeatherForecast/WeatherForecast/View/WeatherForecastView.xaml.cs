using System.Windows;
using WeatherForecast.ViewModel;

namespace WeatherForecast.View
{
    /// <summary>
    /// Interaction logic for WeatherForecastView.xaml
    /// </summary>
    public partial class WeatherForecastView : Window
    {
        /// <summary>
        /// Weather forecast view constructor
        /// </summary>
        /// <param name="weatherForecastVM">Viemodel for weather forecast view</param>
        public WeatherForecastView(WeatherForecastVM weatherForecastVM)
        {
            InitializeComponent();
            this.DataContext = weatherForecastVM;
        }
    }
}
