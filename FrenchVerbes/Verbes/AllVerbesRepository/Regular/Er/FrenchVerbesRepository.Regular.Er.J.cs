using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErJVerbs()
    {
        _verbs.Add(CreateJoncher());
    }

    #region FactoryMethods

    private static RegularErVerb CreateJoncher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Joncher,
            Constants.VerbDescriptions.Regular.Er.Joncher);
    }

    #endregion
}

