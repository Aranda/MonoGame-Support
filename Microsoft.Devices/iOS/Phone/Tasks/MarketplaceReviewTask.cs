using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Microsoft.Phone.Tasks
{
    /// <summary>
    /// Android implementaion of the MarketplaceReviewTask.
    /// </summary>
    public sealed class MarketplaceReviewTask
    {
        public void Show()
        {
            NSUrl appStoreUrl = new NSUrl("itms-apps://itunes.com/app/" + NSBundle.MainBundle.BundleIdentifier);
            UIApplication.SharedApplication.OpenUrl(appStoreUrl);
        }
    }
}
