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
        
        /// <summary>
        /// Returns the contracted form for "Je" + vowel/h mute h, e.g. "Je" + "ai" → "J'"
        /// </summary>
        public static string ContractJe(this string pronoun, string nextWord)
        {
            if (pronoun == Constants.Pronouns.Je && !string.IsNullOrEmpty(nextWord))
            {
                char firstChar = char.ToLower(nextWord[0]);
                if ("aeiouh".Contains(firstChar))
                    return Constants.Pronouns.Je_Contracted;
            }

            return pronoun;
        }
    }
}