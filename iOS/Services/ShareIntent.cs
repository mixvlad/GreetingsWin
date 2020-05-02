using Greetings.Services;
using Greetings.iOS;
using UIKit;
using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(ShareIntent))]
namespace Greetings.iOS
{
    public class ShareIntent : IShareable
    {
        public void OpenShareIntent(string textToShare)
        {
            var activityController = new UIActivityViewController(new NSObject[] { UIActivity.FromObject(textToShare) }, null);
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(activityController, true, null);
        }
    }
}

