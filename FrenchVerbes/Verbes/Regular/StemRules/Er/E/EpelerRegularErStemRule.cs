using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular.StemRules.Er.A;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.E;

public sealed class EpelerRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Epeler;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        bool doubleL = tense switch
        {
            Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4,
            Constants.Tenses.FuturSimple => true,
            Constants.Tenses.ConditionnelPresent => true,
            Constants.Tenses.Imperative => pronounIndex == 1,
            _ => false
        };

        if (doubleL)
        {
            int lastL = stem.LastIndexOf("l");
            if (lastL >= 0)
            {
                stem = stem.Substring(0, lastL) + "ll" + stem.Substring(lastL + 1);
            }
        }

        return stem;
    }
}
