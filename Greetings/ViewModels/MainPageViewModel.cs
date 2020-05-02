using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Greetings.Services;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Greetings.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        INavigationService _navigationService;
        IShareable _shareableService;

        private bool _canNavigateProp;

        public bool CanNavigateProp
        {
            get { return _canNavigateProp; }
            set { SetProperty(ref _canNavigateProp, value); }
        }

        private List<GreetingsListModel> _greetingLists;

        public List<GreetingsListModel> GreetingsLists
        {
            get { return _greetingLists; }
            set { SetProperty(ref _greetingLists, value); }
        }



        public DelegateCommand NavigateCommand { get; set; }

        public ICommand ShareGreetingCommand { get; set; }



        public MainPageViewModel(INavigationService navigationService, IShareable shareableService)
        {
            _navigationService = navigationService;
            _shareableService = shareableService;
            GreetingsLists = GreetingsLoader.LoadGreetingsAsync().GetAwaiter().GetResult();

            NavigateCommand = new DelegateCommand(Navigate).ObservesCanExecute((p) => CanNavigateProp);
            ShareGreetingCommand = new Command<GreetingModel>(ShareGreeting);
        }

        public void ShareGreeting(GreetingModel greeting)
        {
            if (greeting != null)
                _shareableService.OpenShareIntent(greeting.Text);
        }


        public void Navigate()
        {
            
            //_navigationService.Navigate<AboutPageViewModel>();
        }
    }
}

