using System;
using System.Globalization;
using System.Windows.Data;

namespace WeatherForecast.View.Converters
{
   public class WindAngleToDirectionCoverter : IValueConverter
    {

        /// <summary>
        /// Convert Wind Angle To Direction
        /// </summary>
        /// <param name="value">The value in degree</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">The culture</param>
        /// <returns>The value in direction</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var val = ((double)value / 45) + 0.5;
                var a = new char[] { '↑', '↗', '→', '↘', '↓', '↙', '←', '↖' };

                string formattedAngle = string.Format("{0:0.00}", value);
                return $"{formattedAngle} {a[(int)(val % 8)]}";
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Convert data from wind angle to direction was not success. Direction won't be displayed." + ex.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);

                return $"{value}°";
            }
        }

        /// <summary>
        /// Convert Direction to Wind Angle
        /// </summary>
        /// <param name="value">The value Direction</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">The culture</param>
        /// <returns>The value in angle</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
