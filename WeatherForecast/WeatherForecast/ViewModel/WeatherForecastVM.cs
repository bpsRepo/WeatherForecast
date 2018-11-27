using System.Collections.ObjectModel;
using WeatherForecast.DAL;
using WeatherForecast.Model;
using WeatherForecast.ViewModel.BaseClasses;
using System.Threading.Tasks;

namespace WeatherForecast.ViewModel
{
    /// <summary>
    /// Weather Forecast ViewModel
    /// </summary>
    public class WeatherForecastVM : ViewModelBase
    {

        #region Parameters

        private ObservableCollection<List> list;

        private List selectedListItem;

        #endregion

        #region Properties


        public ObservableCollection<List> List
        {
            get { return list; }
            set
            {
                list = value;
                OnPropertyChanged();
            }
        }

        public List SelectedListItem
        {
            get { return selectedListItem; }
            set
            {
                selectedListItem = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}
