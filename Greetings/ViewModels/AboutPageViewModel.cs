using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;

namespace Greetings.ViewModels
{
    public class AboutPageViewModel : BindableBase
    {
        INavigationService _navigationService;

        private string _title = "AboutPage";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand NavigateCommand { get; set; }

        public AboutPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new DelegateCommand(Navigate);
        }

        public void Navigate()
        {
            _navigationService.GoBack();
        }

    }
}

