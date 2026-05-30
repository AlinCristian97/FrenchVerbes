using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.G;

public static class RegularErStemRulesG
{
    public static readonly IReadOnlyDictionary<string, IRegularErStemRule> Rules =
        new Dictionary<string, IRegularErStemRule>
        {
            [Constants.Verbs.Regular.Er.Gerer] = new GererRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Generer] = new GenererRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Geler] = new GelerRegularErStemRule(),
        };
}
