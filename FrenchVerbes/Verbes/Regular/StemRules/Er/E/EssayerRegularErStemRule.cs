using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.E;

public sealed class EssayerRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Essayer;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        // Futur/conditionnel stem is the full infinitive (e.g. "essayer") → replace "ayer" with "aier"
        if (tense == Constants.Tenses.FuturSimple || tense == Constants.Tenses.ConditionnelPresent)
        {
            if (stem.EndsWith("ayer"))
            {
                stem = stem[..^4] + "aier";
            }
            return stem;
        }

        // Présent/impératif: replace trailing "y" with "i" except nous/vous (index 3 & 4)
        bool useI = tense switch
        {
            Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4,
            Constants.Tenses.Imperative => pronounIndex == 1,
            _ => false
        };

        if (useI && stem.EndsWith("ay"))
        {
            stem = stem[..^1] + "i";
        }

        return stem;
    }
}
