using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er;

public sealed class AcheterRegularErStemRule : IRegularErStemRule
{
    public string Infinitive => Constants.Verbs.Regular.Er.Acheter;

    public string Apply(string stem, string tense, int pronounIndex)
    {
        if ((tense == Constants.Tenses.Present || tense == Constants.Tenses.Imparfait) &&
            pronounIndex != 3 && pronounIndex != 4)
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
