using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearCopy.ViewModels
{
    public class MainWindowViewModel :BindableBase
    {

        private readonly IRegionManager _regionManager;

        private DelegateCommand _loadWindowCommand;
        public DelegateCommand LoadWindowCommand
        {
            get { return _loadWindowCommand; }
            set { SetProperty(ref _loadWindowCommand, value); }
        }

        private string _testText;
        public string TestText
        {
            get { return _testText; }
            set { SetProperty(ref _testText, value); }
        }

        public MainWindowViewModel( IRegionManager regionManager)
        {
            _regionManager = regionManager;
            LoadWindowCommand = new DelegateCommand(LoadWindow);
        }

        private void LoadWindow()
        {
            Navigate("SimpleCopyView");
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("SimpleCopyRegion", uri);
        }
    }
}
