using System;
using System.Globalization;
using System.Windows.Data;

namespace WeatherForecast.View.Converters
{
    /// <summary>
    /// Convert between kelvin and celsius
    /// </summary>
    internal class KelvinToCelsiusConverter : IValueConverter
    {
        private readonly double kelvinToCelsiusDifferenceValue = 273.15;

        /// <summary>
        /// Convert kelvin to celsius
        /// </summary>
        /// <param name="value">The value in kelvin</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">The culture</param>
        /// <returns>The value in celsius</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                string celsius = string.Format("{0:0.00}", (double)value - kelvinToCelsiusDifferenceValue);
                return $"{celsius} °C";
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show("Convert data from Kelvin to Celsius was not success. Data will be displayed in Kelvin." + ex.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                return $"{value} K";
            }
        }

        /// <summary>
        /// Convert celsius to kelvin
        /// </summary>
        /// <param name="value">The value in celsius</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">The culture</param>
        /// <returns>The value in kelvin</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
