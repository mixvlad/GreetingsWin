using Greetings.Services;
using Android.Content;
using Xamarin.Forms;
using Greetings.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ShareIntent))]
namespace Greetings.Droid
{
    public class ShareIntent : IShareable
    {
        public void OpenShareIntent(string textToShare)
        {
            var myIntent = new Intent(Android.Content.Intent.ActionSend);      
            myIntent.SetType("text/plain"); 
            myIntent.PutExtra(Intent.ExtraText, textToShare); 
            Forms.Context.StartActivity(Intent.CreateChooser(myIntent, "Choose an App"));
        }
    }
}
