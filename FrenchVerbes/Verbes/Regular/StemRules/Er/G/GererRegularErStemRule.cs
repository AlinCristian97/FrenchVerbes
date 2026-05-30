using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.G;

public sealed class GererRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Gerer;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        bool useGraveAccent = tense switch
        {
            Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4,
            Constants.Tenses.Imperative => pronounIndex == 1,
            _ => false
        };

        if (useGraveAccent)
        {
            int idx = stem.LastIndexOf('é');
            if (idx >= 0)
            {
                stem = stem[..idx] + "è" + stem[(idx + 1)..];
            }
        }

        return stem;
    }
}
