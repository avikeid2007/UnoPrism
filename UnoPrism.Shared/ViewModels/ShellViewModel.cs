﻿using Prism.Commands;
using Prism.Regions;

namespace UnoPrism.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private IRegionManager _regionManager;
        public DelegateCommand NavToLoginCommand { get; set; }
        public ShellViewModel(IRegionManager regionManager)
        {
            Title = "Main Page";
            _regionManager = regionManager;
            NavToLoginCommand = new DelegateCommand(NavToLoginCommandExecuted);
            // regionManager.RequestNavigate("ContentRegion", "Login");
        }

        private void NavToLoginCommandExecuted()
        {
            _regionManager.RequestNavigate("ContentRegion", "Login");
        }
    }
}
