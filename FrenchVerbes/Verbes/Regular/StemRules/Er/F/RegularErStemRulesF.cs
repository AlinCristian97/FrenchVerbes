using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.F;

public static class RegularErStemRulesF
{
    public static readonly IReadOnlyDictionary<string, IRegularErStemRule> Rules =
        new Dictionary<string, IRegularErStemRule>
        {
            [Constants.Verbs.Regular.Er.Feuilleter] = new FeuilleterRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Foudroyer] = new FoudroyerRegularErStemRule(),
        };
}
