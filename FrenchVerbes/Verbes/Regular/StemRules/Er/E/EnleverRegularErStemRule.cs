using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.E;

public sealed class EnleverRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Enlever;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        bool useGraveAccent = tense switch
        {
            Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4,
            Constants.Tenses.Imperative => pronounIndex == 1,
            Constants.Tenses.FuturSimple => true,
            Constants.Tenses.ConditionnelPresent => true,
            _ => false
        };

        if (useGraveAccent)
        {
            stem = stem.Replace("enlev", "enlèv");
        }

        return stem;
    }
}
