using FrenchVerbes.Extensions;

namespace FrenchVerbes;

public static class PrintUtils
{
    public static void PrintSectionDivider(bool newLine = true)
    {
        if (newLine)
        {
            Console.WriteLine(Constants.SectionDivider);
            return;
        }
        Console.Write(Constants.SectionDivider);
    }
    
    public static void PrintHeadline(string headline)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(headline.ToHeadline());
        Console.ResetColor();
    }


    public static void PrintPronoun(int pronounIndex, string verb)
    {
        // Apply elision only for "Je"
        string pronoun = pronounIndex == 0 ? ElideJeIfNeeded(verb) : Constants.Pronouns.All[pronounIndex];
        Console.Write($"{pronoun}{(pronoun == Constants.Pronouns.Je_Contracted ? "" : " ")}");
    }

    #region Private Methods

    // Apply elision only for Je + stem starting with a vowel/mute h
    private static string ElideJeIfNeeded(string nextWord)
    {
        if (!string.IsNullOrEmpty(nextWord) && Constants.Vowels.Contains(nextWord[0]))
            return Constants.Pronouns.Je_Contracted;
        
        return Constants.Pronouns.Je;
    }

    #endregion
}