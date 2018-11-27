using System.Collections.ObjectModel;
using Unity;
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

        /// <summary>
        /// Constructor for WeatherForecast ViewModel
        /// </summary>
        /// <param name="dataCollector">A data collector class</param>
        /// <param name="dataParser">A parser class</param>
        public WeatherForecastVM(IDataCollector dataCollector, IDataParser dataParser)
        {
            this.dataCollector = dataCollector;
            this.dataParser = dataParser;
        }

        /// <summary>
        /// Initialize the list property
        /// </summary>
        /// <returns></returns>
        private Task Initialize()
        {
            return Task.Run(() =>
            {
                string collectedData = dataCollector.Collect();
                this.List = new ObservableCollection<List>(dataParser.ParseWeatherForecastData(collectedData).list);
            });
        }

        #region Parameters

        private IDataParser dataParser;

        private IDataCollector dataCollector;

        private ObservableCollection<List> list;

        private List selectedListItem;

        private RelayCommand formLoadedCommand;

        #endregion

        #region Properties

        /// <summary>
        /// Form loaded command property
        /// </summary>
        public RelayCommand FormLoadedCommand
        {
            get
            {
                return formLoadedCommand
                  ?? (formLoadedCommand = new RelayCommand(
                    async (param) =>
                    {
                        await Initialize();
                    }));
            }
        }

        /// <summary>
        /// List of weather forecast data
        /// </summary>
        public ObservableCollection<List> List
        {
            get { return list; }
            set
            {
                list = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Represent a selected listitem
        /// </summary>
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
