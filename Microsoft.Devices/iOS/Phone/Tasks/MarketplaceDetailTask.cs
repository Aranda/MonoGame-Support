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
        // Appstore bundle name, or other content identifier. When using the bundle name
        // you must remove all white space and punctuation characters.
        public string ContentIdentifier { get; set; }

        // The content type. If MarketplaceContentType.Music is used,
        // The ContentIdentifier is assumed to be for an album
        public MarketplaceContentType ContentType { get; set; }

        public void Show()
        {
            NSUrl appStoreUrl;
            if (ContentType == MarketplaceContentType.Applications)
            {
                if (ContentIdentifier == null)
                {
                    ContentIdentifier = ContentIdHelper.GetCurrentContentIdentifier();
                }
                appStoreUrl = new NSUrl("itms-apps://itunes.com/app/" + ContentIdentifier);
            }
            else
            {
                if (ContentIdentifier == null)
                {
                    throw new System.InvalidOperationException("Can not open MarketplaceContentType.Music URL without an explicit ContentIdentifier");
                }
                appStoreUrl = new NSUrl("itms://itunes.com/album/" + ContentIdentifier);
            }

            UIApplication.SharedApplication.OpenUrl(appStoreUrl);
        }
    }
}
