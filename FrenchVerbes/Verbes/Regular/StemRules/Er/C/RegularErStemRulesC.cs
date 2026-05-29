using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.C;

public static class RegularErStemRulesC
{
    public static readonly IReadOnlyDictionary<string, IRegularErStemRule> Rules =
        new Dictionary<string, IRegularErStemRule>
        {
            [Constants.Verbs.Regular.Er.Celebrer] = new CelebrerRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Cooperer] = new CoopererRegularErStemRule(),
        };
}
