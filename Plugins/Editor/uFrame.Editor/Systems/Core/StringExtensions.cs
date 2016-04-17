using System.Text.RegularExpressions;

namespace Invert.Core
{
    public static class StringExtensions
    {
        public static string PrettyLabel(this string label)
        {
            return Regex.Replace(label, @"[^\w\s]|_", "");
        }
    }
}