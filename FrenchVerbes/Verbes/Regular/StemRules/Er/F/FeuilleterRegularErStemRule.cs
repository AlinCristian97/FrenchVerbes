using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.F;

public sealed class FeuilleterRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Feuilleter;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        // Double the final 't' only in présent and impératif (tu)
        // No doubling and no accent in futur simple or conditionnel présent
        bool doubleT = tense switch
        {
            Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4,
            Constants.Tenses.Imperative => pronounIndex == 1,
            _ => false
        };

        if (doubleT)
        {
            int lastT = stem.LastIndexOf('t');
            if (lastT >= 0)
            {
                stem = stem[..lastT] + "tt" + stem[(lastT + 1)..];
            }
        }

        return stem;
    }
}
