using ClientApp.Core;

namespace ClientApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }


        private HomeViewModel HomeVM
        {
            get;
            set;
        }
        private SettingsViewModel SettingsVM
        {
            get;
            set;
        }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            SettingsVM = new SettingsViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand((obj) =>
            {
                CurrentView = HomeVM;

            });
            SettingsViewCommand = new RelayCommand((obj) =>
            {
                CurrentView = SettingsVM;

            });
        }
    }
}
