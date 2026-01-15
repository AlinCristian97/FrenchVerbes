namespace FrenchVerbes.Verbes.Regular;

public class RegularErVerb : RegularVerb
{
    public RegularErVerb(string infinitive, string description, bool usesEtre = false, NotesObject? tensesNotes = null) : base(infinitive,
        description, usesEtre, tensesNotes)
    {
        
    }

    protected override string Ending => "er";
    
    private const string specialCerEnding = "cer";
    private const string specialGerEnding = "ger";
    
    protected override string PastParticipleSuffix => "é";
    
    protected override string[] PresentTenseEndings => new[] { "e", "es", "e", "ons", "ez", "ent" };
    protected override string[] ImperativeEndings => new[] { "e", "ons", "ez" };
    
    // Dictionary for special stem rules
    private static readonly Dictionary<string, Func<string, string, int, string>> SpecialStemRules = new()
    {
        // acheter: e -> è for Je/Tu/Il/Elle/On/Ils/Elles (except Nous/Vous)
        [Constants.Verbs.Regular.Er.Acheter] = (stem, tense, pronounIndex) =>
        {
            if ((tense == Constants.Tenses.Present || tense == Constants.Tenses.Imparfait) &&
                pronounIndex != 3 && pronounIndex != 4)
            {
                int index = stem.LastIndexOf("e");
                if (index >= 0) stem = stem.Substring(0, index) + "è" + stem.Substring(index + 1);
            }
            return stem;
        },

        // manger: add 'e' before 'ons' for Nous and provide 'e' for Imparfait (mangeais, etc.)
        [Constants.Verbs.Regular.Er.Manger] = (stem, tense, pronounIndex) =>
        {
            // Add 'e' for Nous present/imperative and for all persons in Imparfait
            if ((tense == Constants.Tenses.Present && pronounIndex == 3) ||  // Nous present
                (tense == Constants.Tenses.Imparfait) ||                      // all persons in imparfait
                (tense == Constants.Tenses.Imperative && pronounIndex == 3)) // Nous imperative
            {
                if (!stem.EndsWith("e"))
                    stem += "e";
            }
            return stem;
        },

        [Constants.Verbs.Regular.Er.Appeler] = (stem, tense, pronounIndex) =>
        {
            bool doubleL = tense switch
            {
                Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4, // Je/Tu/Il/Elle/On/Ils/Elles
                Constants.Tenses.FuturSimple => true,   // all persons
                Constants.Tenses.ConditionnelPresent => true, // all persons
                Constants.Tenses.Imperative => pronounIndex == 1, // Tu imperative
                _ => false
            };

            if (doubleL)
            {
                int lastL = stem.LastIndexOf("l");
                if (lastL >= 0)
                    stem = stem.Substring(0, lastL) + "ll" + stem.Substring(lastL + 1);
            }

            return stem;
        },
        
    };
    
    private string GetAdjustedStem(string stem, string tense, int pronounIndex)
    {
        bool specialHandled = false;
    
        if (SpecialStemRules.TryGetValue(Infinitive, out var rule))
        {
            stem = rule(stem, tense, pronounIndex);
            specialHandled = true;
        }

        // Only apply generic CER/GER rules if special rule didn't already do it
        if (!specialHandled)
        {
            if (Infinitive.EndsWith(specialGerEnding) &&
                pronounIndex == 3 &&
                (tense == Constants.Tenses.Present || tense == Constants.Tenses.Imperative))
            {
                stem += "e";
            }

            if (Infinitive.EndsWith(specialCerEnding) &&
                pronounIndex == 3 &&
                tense == Constants.Tenses.Present)
            {
                stem = stem[..^1] + Constants.FrenchSymbols.CedillaC;
            }
        }

        return stem;
    }
    
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
        string tense = Constants.Tenses.Present;
        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);

        string stem = GetStemForTense(tense);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string adjustedStem = GetAdjustedStem(stem, tense, i);

            PrintUtils.PrintPronoun(i, adjustedStem);
            Console.ForegroundColor = ConsoleColor.Green;
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
            string adjustedStem = GetAdjustedStem(stem, tense, i);

            PrintUtils.PrintPronoun(i, adjustedStem);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(adjustedStem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ImparfaitEndings[i]);
            Console.ResetColor();
        }
    }
    
    protected override void PrintFuturSimple()
    {
        string tense = Constants.Tenses.FuturSimple;
        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);

        string stem = GetStemForTense(tense);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string adjustedStem = GetAdjustedStem(stem, tense, i);

            PrintUtils.PrintPronoun(i, adjustedStem);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(adjustedStem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FuturSimpleEndings[i]);
            Console.ResetColor();
        }
    }

    protected override void PrintConditionnelPresent()
    {
        string tense = Constants.Tenses.ConditionnelPresent;
        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);

        string stem = GetStemForTense(tense);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string adjustedStem = GetAdjustedStem(stem, tense, i);

            PrintUtils.PrintPronoun(i, adjustedStem);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(adjustedStem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ConditionnelPresentEndings[i]);
            Console.ResetColor();
        }
    }

    protected override void PrintImperative()
    {
        string tense = Constants.Tenses.Imperative;
        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
        string stem = GetStemForTense(Constants.Tenses.Present);

        int[] indices = { 1, 3, 4 }; // Tu, Nous, Vous

        for (int i = 0; i < indices.Length; i++)
        {
            int pronounIndex = indices[i];
            string adjustedStem = GetAdjustedStem(stem, tense, pronounIndex);

            Console.Write(adjustedStem);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ImperativeEndings[i]);
            Console.ResetColor();
            Console.WriteLine(" !");
        }
    }
}
