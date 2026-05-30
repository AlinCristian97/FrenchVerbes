using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular.StemRules.Er.A;

namespace FrenchVerbes.Verbes.Regular.StemRules.Er.E;

public static class RegularErStemRulesE
{
    public static readonly IReadOnlyDictionary<string, IRegularErStemRule> Rules =
        new Dictionary<string, IRegularErStemRule>
        {
            [Constants.Verbs.Regular.Er.Ennuyer] = new AppuyerRegularErStemRule(Constants.Verbs.Regular.Er.Ennuyer),
            [Constants.Verbs.Regular.Er.Se_Ennuyer] = new AppuyerRegularErStemRule(Constants.Verbs.Regular.Er.Se_Ennuyer),
            [Constants.Verbs.Regular.Er.Esperer] = new EspererRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Essayer] = new EssayerRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Exagerer] = new ExagererRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Elever] = new EleverRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Epeler] = new EpelerRegularErStemRule(),
            [Constants.Verbs.Regular.Er.Enlever] = new EnleverRegularErStemRule(),
        };
}
