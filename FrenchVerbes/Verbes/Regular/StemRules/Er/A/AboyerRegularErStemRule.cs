using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.A;

public sealed class AboyerRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Aboyer;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        // Futur/conditionnel stem is the full infinitive (e.g. "aboyer") → replace "oyer" with "oier"
        if (tense == Constants.Tenses.FuturSimple || tense == Constants.Tenses.ConditionnelPresent)
        {
            if (stem.EndsWith("oyer"))
            {
                stem = stem[..^4] + "oier";
            }
            return stem;
        }

        // Présent/impératif stem is truncated (e.g. "aboy") → replace trailing "y" with "i"
        bool useI = tense switch
        {
            Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4,
            Constants.Tenses.Imperative => pronounIndex == 1,
            _ => false
        };

        if (useI && stem.EndsWith("oy"))
        {
            stem = stem[..^1] + "i";
        }

        return stem;
    }
}
