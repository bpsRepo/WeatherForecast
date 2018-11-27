using System.Collections.ObjectModel;
using WeatherForecast.DAL;
using WeatherForecast.Model;
using WeatherForecast.ViewModel.BaseClasses;
using System.Threading.Tasks;
using Unity;

namespace WeatherForecast.ViewModel
{
    /// <summary>
    /// Weather Forecast ViewModel
    /// </summary>
    public class WeatherForecastVM : ViewModelBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public WeatherForecastVM()
        {
            objectContainer = new UnityContainer();
            objectContainer.RegisterType<IDataCollector, LiveDataCollector>();
            objectContainer.RegisterType<IDataParser, JSONParser>();

            dataCollector = objectContainer.Resolve<IDataCollector>();
            dataParser = objectContainer.Resolve<IDataParser>();

            string collectedData = dataCollector.Collect();
            this.List = new ObservableCollection<List>(dataParser.ParseWeatherForecastData(collectedData).list);
        }

        #region Parameters

        private IUnityContainer objectContainer;

        private IDataParser dataParser;

        private IDataCollector dataCollector;

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
