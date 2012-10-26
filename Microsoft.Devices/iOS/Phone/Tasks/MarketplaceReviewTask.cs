using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Microsoft.Phone.Tasks
{
    /// <summary>
    /// iOS implementaion of the MarketplaceReviewTask.
    /// </summary>
    public sealed class MarketplaceReviewTask
    {
        public void Show()
        {
            NSUrl appStoreUrl = new NSUrl("itms-apps://itunes.com/app/" + ContentIdHelper.GetCurrentContentIdentifier());
            UIApplication.SharedApplication.OpenUrl(appStoreUrl);
        }
    }
}
