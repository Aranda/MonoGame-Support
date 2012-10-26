using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Microsoft.Phone.Tasks
{
    /// <summary>
    /// iOS implementation of the WebBrowserTask
    /// </summary>
    public sealed class WebBrowserTask
    {
        // Uri for target web site
        public System.Uri Uri { get; set; }

        public void Show()
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(Uri.OriginalString));
        }
    }
}