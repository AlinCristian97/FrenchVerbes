using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.A;

public sealed class AcheverRegularErStemRule : IRegularErStemRule
{
    private readonly string _infinitive;

    public AcheverRegularErStemRule(string infinitive)
    {
        _infinitive = infinitive;
    }

    public string Infinitive => _infinitive;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        if (tense == Constants.Tenses.FuturSimple || tense == Constants.Tenses.ConditionnelPresent)
        {
            // achever → achèver- (futur: j'achèverai)
            // Use IndexOf to find the first 'e' (in "ach[e]ver"), not the last
            int idx = stem.IndexOf("e");
            if (idx >= 0)
            {
                stem = stem[..idx] + "è" + stem[(idx + 1)..];
            }

            return stem;
        }

        bool useGraveAccent = tense switch
        {
            Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4,
            Constants.Tenses.Imperative => pronounIndex == 1,
            _ => false
        };

        if (useGraveAccent)
        {
            int idx = stem.LastIndexOf("e");
            if (idx >= 0)
            {
                stem = stem[..idx] + "è" + stem[(idx + 1)..];
            }
        }

        return stem;
    }
}
