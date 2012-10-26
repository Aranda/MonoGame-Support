using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Microsoft.Phone.Tasks
{
    /// <summary>
    /// iOS implementaion of the MarketplaceDetailTask.
    ///
    /// References:
    ///     http://monotouch.2284126.n4.nabble.com/Opening-App-Store-by-pressing-a-button-inside-my-app-td4408091.html
    ///     http://stackoverflow.com/questions/433907/how-to-link-to-apps-on-the-app-store 
    /// </summary>
    public sealed class MarketplaceDetailTask
    {
        // Appstore bundle name, or content identifier. When using the bundle name
        // you must remove all white space and punctuation characters.
        public string ContentIdentifier { get; set; }

        // Ignored by this implementation
        public MarketplaceContentType ContentType { get; set; }

        public void Show()
        {
            if (ContentIdentifier == null)
            {
                ContentIdentifier = NSBundle.MainBundle.BundleIdentifier;
            }

            NSUrl appStoreUrl = new NSUrl("itms-apps://itunes.com/app/" + ContentIdentifier);
            UIApplication.SharedApplication.OpenUrl(appStoreUrl);
        }
    }
}
