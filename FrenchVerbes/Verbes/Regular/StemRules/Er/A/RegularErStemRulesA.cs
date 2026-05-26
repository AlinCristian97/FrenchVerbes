using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.A;

public static class RegularErStemRulesA
{
    public static readonly IReadOnlyDictionary<string, IRegularErStemRule> Rules =
        new Dictionary<string, IRegularErStemRule>
        {
            [Constants.Verbs.Regular.Er.Acheter] = new AcheterRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Appeler] = new AppelerRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Atteler] = new AttelerRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Achever] = new AcheverRegularErStemRule(Constants.Verbs.Regular.Er.Achever),
            [Constants.Verbs.Regular.Er.Se_Achever] = new AcheverRegularErStemRule(Constants.Verbs.Regular.Er.Se_Achever),
        };
}
