using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.M;

public sealed class MangerRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Manger;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        if ((tense == Constants.Tenses.Present && pronounIndex == 3) ||
            tense == Constants.Tenses.Imparfait ||
            (tense == Constants.Tenses.Imperative && pronounIndex == 3))
        {
            if (!stem.EndsWith("e"))
            {
                stem += "e";
            }
        }

        return stem;
    }
}
