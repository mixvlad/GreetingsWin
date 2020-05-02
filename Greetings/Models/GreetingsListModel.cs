using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace Greetings
{
    public class GreetingsListModel : BindableBase
    {
        public string Type { get; set; }

        private DateTime _holidayDate;

        public DateTime HolidayDate
        {
            get
            {
                return _holidayDate;
            }
            set
            {
                var holidayDate = value.AddYears(DateTime.Now.Year - value.Year);
                if (holidayDate < DateTime.Now.Date)
                {
                    _holidayDate = holidayDate.AddYears(1);
                }
                else
                {
                    _holidayDate = holidayDate;
                }
            }
        }

        private GreetingModel _selectedGreeting;

        public GreetingModel SelectedGreeting
        {
            get { return _selectedGreeting; }
            set { SetProperty(ref _selectedGreeting, value); }
        }

        public ObservableCollection<GreetingModel> Greetings { get; set; }

        //        private BitmapImage _icon;
        //
        //        public BitmapImage Icon
        //        {
        //            get
        //            {
        //                if (_icon == null)
        //                {
        //                    _icon = ImageLoader.LoadImage(IconName, GreetingsRepository.IconsFolderName);
        //                }
        //
        //                return _icon;
        //            }
        //        }

        public string BackgroundColor { get; set; } = "Gray";

        private string _iconName;

        public string IconName
        {
            get
            {
                return _iconName;
            }
            set
            {
                _iconName = value;
            }
        }

        public GreetingsListModel()
        {
        }

        public GreetingsListModel(string type, ObservableCollection<GreetingModel> greetings)
        {
            Type = type;
            Greetings = greetings;
        }
    }
}

