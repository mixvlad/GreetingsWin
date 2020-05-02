using System;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Greetings.Views;
using Greetings.ViewModels;

namespace Greetings
{
    public class Bootstrapper : UnityBootstrapper
    {
        #region implemented abstract members of Bootstrapper

        protected override Xamarin.Forms.Page CreateMainPage()
        {
            return Container.Resolve<MainPage>();
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<AboutPage, AboutPageViewModel>();
        }

        #endregion

    }
}

