using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WeatherForecast.ViewModel.BaseClasses
{
    /// <summary>
    /// Base ViewModel class for the ViewModels
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
