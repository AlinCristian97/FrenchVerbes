using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.D;

public sealed class DecelerRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Deceler;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        if (tense == Constants.Tenses.FuturSimple || tense == Constants.Tenses.ConditionnelPresent)
        {
            // déceler → décèler- (futur: je décèlerai)
            // Use IndexOf to target the 'e' in "cel", not the trailing 'e' before 'r'
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
