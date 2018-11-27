using System;
using System.Globalization;
using System.Windows.Data;

namespace WeatherForecast.View.Converters
{
    public class MeterPerSecToKmPerHourConverter : IValueConverter
    {
        private readonly double msToKmphMultiplier = 3.6;

        /// <summary>
        /// Convert m/s to km/h
        /// </summary>
        /// <param name="value">The value in m/s</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">The culture</param>
        /// <returns>The value in km/h</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                string kmph = string.Format("{0:0.00}", (double)value* msToKmphMultiplier);
                return $"{kmph} km/h";
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Convert data from m/s to km/h was not success. Data will be displayed in m/s." + ex.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);

                return $"{value} m/s";
            }
        }

        /// <summary>
        /// Convert km/h to m/s
        /// </summary>
        /// <param name="value">The value in km/h</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">The culture</param>
        /// <returns>The value in m/s</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
