namespace FrenchVerbes.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a string to a "headline" style for console:
        /// uppercase and optionally surrounded by symbols.
        /// </summary>
        public static string ToHeadline(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return $"*** {text.ToUpper()} ***";
        }
    }
}