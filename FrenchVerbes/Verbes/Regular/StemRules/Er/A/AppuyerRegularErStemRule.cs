using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.A;

public sealed class AppuyerRegularErStemRule : IRegularErStemRule
{
    private readonly string _infinitive;

    public AppuyerRegularErStemRule(string infinitive)
    {
        _infinitive = infinitive;
    }

    public string Infinitive => _infinitive;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        // Futur/conditionnel stem is the full infinitive (e.g. "appuyer") → replace "uyer" with "uier"
        if (tense == Constants.Tenses.FuturSimple || tense == Constants.Tenses.ConditionnelPresent)
        {
            if (stem.EndsWith("uyer"))
            {
                stem = stem[..^4] + "uier";
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

        if (useI && stem.EndsWith("uy"))
        {
            stem = stem[..^1] + "i";
        }

        return stem;
    }
}
