using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular.StemRules.Er;
using FrenchVerbes.Verbes.Regular.StemRules.Er.A;
using FrenchVerbes.Verbes.Regular.StemRules.Er.C;
using FrenchVerbes.Verbes.Regular.StemRules.Er.D;
using FrenchVerbes.Verbes.Regular.StemRules.Er.E;
using FrenchVerbes.Verbes.Regular.StemRules.Er.M;

namespace FrenchVerbes.Verbes.Regular;

public class RegularErVerb : RegularVerb
{
    public RegularErVerb(string infinitive, string description, bool usesEtre = false, bool isReflexive = false, bool hasReflexive = false, NotesObject? tensesNotes = null) : base(infinitive,
        description, usesEtre, isReflexive, hasReflexive, tensesNotes)
    {

    }

    protected override string Ending => "er";

    private const string specialCerEnding = "cer";
    private const string specialGerEnding = "ger";
    
    protected override string PastParticipleSuffix => "é";
    
    protected override string[] PresentTenseEndings => new[] { "e", "es", "e", "ons", "ez", "ent" };
    protected override string[] ImperativeEndings => new[] { "e", "ons", "ez" };
    
    // Dictionary for special stem rules
    private static readonly Dictionary<string, IRegularErStemRule> SpecialStemRules = BuildSpecialStemRules();

    private static Dictionary<string, IRegularErStemRule> BuildSpecialStemRules()
    {
        var rules = new Dictionary<string, IRegularErStemRule>();

        AddRules(rules, RegularErStemRulesA.Rules);
        AddRules(rules, RegularErStemRulesC.Rules);
        AddRules(rules, RegularErStemRulesD.Rules);
        AddRules(rules, RegularErStemRulesE.Rules);
        AddRules(rules, RegularErStemRulesM.Rules);

        return rules;
    }

    private static void AddRules(Dictionary<string, IRegularErStemRule> target, IReadOnlyDictionary<string, IRegularErStemRule> source)
    {
        foreach (var rule in source)
        {
            target[rule.Key] = rule.Value;
        }
    }
    
    private string GetAdjustedStem(string stem, string tense, int pronounIndex)
    {
        bool specialHandled = false;
    
        if (SpecialStemRules.TryGetValue(Infinitive, out var rule))
        {
            stem = rule.Apply(stem, tense, pronounIndex);
            specialHandled = true;
        }

        // Only apply generic CER/GER rules if special rule didn't already do it
        if (!specialHandled)
        {
            if (Infinitive.EndsWith(specialGerEnding))
            {
                if (pronounIndex == 3 &&
                    (tense == Constants.Tenses.Present || tense == Constants.Tenses.Imperative))
                {
                    stem += "e";
                }

                if (tense == Constants.Tenses.Imparfait && pronounIndex != 3 && pronounIndex != 4)
                {
                    stem += "e";
                }
            }

            if (Infinitive.EndsWith(specialCerEnding))
            {
                if (pronounIndex == 3 && tense == Constants.Tenses.Present)
                {
                    stem = stem[..^1] + Constants.FrenchSymbols.CedillaC;
                }

                if (tense == Constants.Tenses.Imparfait && pronounIndex != 3 && pronounIndex != 4)
                {
                    stem = stem[..^1] + Constants.FrenchSymbols.CedillaC;
                }

                if (tense == Constants.Tenses.Imperative && pronounIndex == 3)
                {
                    stem = stem[..^1] + Constants.FrenchSymbols.CedillaC;
                }
            }
        }

        return stem;
    }
    
    protected override string GetStemForTense(string tense)
    {
        string infinitive = BareInfinitive;
        string stem = tense switch
        {
            Constants.Tenses.Present or Constants.Tenses.Imparfait => infinitive[..^Ending.Length],
            Constants.Tenses.FuturSimple or Constants.Tenses.ConditionnelPresent => infinitive,
            _ => infinitive
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

            PrintUtils.PrintPronoun(i, IsReflexive ? Constants.Pronouns.Reflexive.All[i] : adjustedStem);
            if (IsReflexive)
            {
                string refl = Constants.Pronouns.Reflexive.All[i];
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(ElideReflexivePronoun(refl, adjustedStem));
            }
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

            PrintUtils.PrintPronoun(i, IsReflexive ? Constants.Pronouns.Reflexive.All[i] : adjustedStem);
            if (IsReflexive)
            {
                string refl = Constants.Pronouns.Reflexive.All[i];
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(ElideReflexivePronoun(refl, adjustedStem));
            }
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

            PrintUtils.PrintPronoun(i, IsReflexive ? Constants.Pronouns.Reflexive.All[i] : adjustedStem);
            if (IsReflexive)
            {
                string refl = Constants.Pronouns.Reflexive.All[i];
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(ElideReflexivePronoun(refl, adjustedStem));
            }
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

            PrintUtils.PrintPronoun(i, IsReflexive ? Constants.Pronouns.Reflexive.All[i] : adjustedStem);
            if (IsReflexive)
            {
                string refl = Constants.Pronouns.Reflexive.All[i];
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(ElideReflexivePronoun(refl, adjustedStem));
            }
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
        // Reflexive imperative post-verbal pronouns: toi, nous, vous
        string[] reflexiveImperativePronouns = { "toi", "nous", "vous" };

        for (int i = 0; i < indices.Length; i++)
        {
            int pronounIndex = indices[i];
            string adjustedStem = GetAdjustedStem(stem, tense, pronounIndex);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(adjustedStem);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ImperativeEndings[i]);
            Console.ResetColor();
            if (IsReflexive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"-{reflexiveImperativePronouns[i]}");
                Console.ResetColor();
            }
            Console.WriteLine(" !");
        }
    }
}
