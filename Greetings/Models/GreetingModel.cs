using System;

namespace Greetings
{
    public class GreetingModel : ObservableObject
    {
        public string Title { get; set; }

        public string Text { get; set; }

        public string Author { get; set; }

        public string Link { get; set; }

        public GreetingModel()
        {
        }

        public GreetingModel(string title, string text)
        {
            Title = title;
            Text = text;
        }
    }
}

