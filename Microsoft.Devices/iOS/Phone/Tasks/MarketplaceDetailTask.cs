
namespace Microsoft.Phone.Tasks
{
    /// <summary>
    /// Android implementaion of the MarketplaceDetailTask.
    /// </summary>
    public sealed class MarketplaceDetailTask
    {
        // Android package name, eg "com.rovio.angrybirds"
        public string ContentIdentifier { get; set; }

        // Ignored by this implementation
        public MarketplaceContentType ContentType { get; set; }

        public void Show()
        {
        }
    }
}
