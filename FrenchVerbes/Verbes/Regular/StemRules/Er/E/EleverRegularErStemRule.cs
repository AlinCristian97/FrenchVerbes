using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.E;

public sealed class EleverRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Elever;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        bool useGraveAccent = tense switch
        {
            Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4,
            Constants.Tenses.Imperative => pronounIndex == 1,
            Constants.Tenses.FuturSimple => pronounIndex != 3 && pronounIndex != 4,
            Constants.Tenses.ConditionnelPresent => pronounIndex != 3 && pronounIndex != 4,
            _ => false
        };

        if (useGraveAccent)
        {
            stem = stem.Replace("élev", "élèv");
        }

        return stem;
    }
}
