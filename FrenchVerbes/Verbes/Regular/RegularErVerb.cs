using FrenchVerbes.Extensions;

namespace FrenchVerbes.Verbes.Regular;

public class RegularErVerb : RegularVerb
{
    public RegularErVerb(string infinitive, string description, NotesObject? tensesNotes = null) : base(infinitive,
        description, tensesNotes)
    {
        
    }

    protected override string Ending => "er";
    
    private const string specialCerEnding = "cer";
    private const string specialGerEnding = "ger";
    
    protected override string PastParticipleSuffix => "é";
    
    protected override string[] PresentTenseEndings => new[] { "e", "es", "e", "ons", "ez", "ent" };
    protected override string[] ImperativeEndings => new[] { "e", "ons", "ez" };
    
    protected override string GetStemForTense(string tense)
    {
        string stem = tense switch
        {
            Constants.Tenses.Present or Constants.Tenses.Imparfait => Infinitive[..^Ending.Length],
            Constants.Tenses.FuturSimple or Constants.Tenses.ConditionnelPresent => Infinitive,
            _ => Infinitive
        };

        return stem;
    }
    
    protected override void PrintPresent()
    {
        base.PrintPresent();
        string stem = GetStemForTense(Constants.Tenses.Present);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string adjustedStem = stem;

            // Special rules for -GER verbs: add 'e' before 'ons'
            if (Infinitive.EndsWith(specialGerEnding) && i == 3) // "Nous" form
                adjustedStem += "e";

            // Special rules for -CER verbs: c -> ç before 'ons'
            if (Infinitive.EndsWith(specialCerEnding) && i == 3) // "Nous" form
                adjustedStem = adjustedStem[..^1] + Constants.FrenchSymbols.CedillaC;

            Console.Write($"{Constants.Pronouns.All[i]} ");

            if (adjustedStem == Infinitive) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(adjustedStem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(PresentTenseEndings[i]);
            Console.ResetColor();
        }
    }

    protected override void PrintImparfait()
    {
        string tense = Constants.Tenses.Imparfait;

        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
        string stem = GetStemForTense(tense);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string adjustedStem = stem;

            // Special rule for -CER verbs: c -> ç before 'ais', 'ions', 'iez', 'aient'
            if (Infinitive.EndsWith(specialCerEnding))
            {
                // Only need to adjust the stem if it ends in 'c'
                if (stem.EndsWith("c")) adjustedStem = stem[..^1] + Constants.FrenchSymbols.CedillaC;
            }

            // Special rule for -GER verbs: add 'e' before 'ais', 'ions', 'iez', 'aient' if necessary
            if (Infinitive.EndsWith(specialGerEnding))
            {
                // Add 'e' only for Je/Tu/Il/Elle/On/Il/Elle/On/Ils/Elles, not for Nous/Vous
                if (i != 3 && i != 4) 
                    adjustedStem += "e";
            }

            Console.Write($"{Constants.Pronouns.All[i]} ");

            if (adjustedStem == Infinitive) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(adjustedStem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ImparfaitEndings[i]);
            Console.ResetColor();
        }
    }

    protected override void PrintImperative()
    {
        base.PrintImperative();
        string stem = GetStemForTense(Constants.Tenses.Present);
        
        // Indices in the full pronoun list: 1 (Tu), 3 (Nous), 4 (Vous)
        int[] indices = { 1, 3, 4 };

        for (int i = 0; i < indices.Length; i++)
        {
            string adjustedStem = stem;
            int pronounIndex = indices[i];

            if (Infinitive.EndsWith(specialGerEnding) && pronounIndex == 3) adjustedStem += "e";
            if (Infinitive.EndsWith(specialCerEnding) && pronounIndex == 3) adjustedStem = adjustedStem[..^1] + Constants.FrenchSymbols.CedillaC;

            Console.Write(adjustedStem);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ImperativeEndings[i]);
            Console.ResetColor();
            Console.WriteLine(" !");
        }
    }
}
