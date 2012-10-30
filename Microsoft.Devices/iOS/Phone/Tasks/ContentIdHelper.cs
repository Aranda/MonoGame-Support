using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Microsoft.Phone.Tasks
{
    internal static class ContentIdHelper
    {
        // Gets the safe bundle name from the current bundle. This can be 
        // used as part of a itms:// url to open the app store
        internal static string GetCurrentContentIdentifier()
        {
            string bundleName = NSBundle.MainBundle.InfoDictionary[new NSString("CFBundleName")].ToString();
            return StripUnsafeCharacters(bundleName);
        }
        
        // Removes any characters that are not letters or digits from the input string
        internal static string StripUnsafeCharacters(string input)
        {
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            foreach (char c in input)
            {
                // Ampersand gets converted to "and"!!
                if (c == '&')
                    output.Append("and");

                // All alphanumeric characters are added
                if (char.IsLetterOrDigit(c))
                    output.Append(c);
            }
            return output.ToString();
        }
    }
}