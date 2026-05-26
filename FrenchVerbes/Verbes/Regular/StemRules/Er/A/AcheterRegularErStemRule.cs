using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.A;

public sealed class AcheterRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Acheter;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        if (tense == Constants.Tenses.FuturSimple || tense == Constants.Tenses.ConditionnelPresent)
        {
            if (stem.EndsWith("eter"))
            {
                stem = stem[..^4] + "è" + stem[^3..];
            }

            return stem;
        }

        bool useGraveAccent = tense switch
        {
            Constants.Tenses.Present => pronounIndex != 3 && pronounIndex != 4, // Je/Tu/Il/Elle/On/Ils/Elles
            Constants.Tenses.Imperative => pronounIndex == 1, // Tu
            _ => false
        };

        if (useGraveAccent)
        {
            int index = stem.LastIndexOf("e");
            if (index >= 0)
            {
                stem = stem.Substring(0, index) + "è" + stem.Substring(index + 1);
            }
        }

        return stem;
    }
}
