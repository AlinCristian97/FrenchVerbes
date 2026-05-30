using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErEVerbs()
    {
        _verbs.Add(CreateEnvisager());
    }

    #region FactoryMethods

    private static RegularErVerb CreateEnvisager()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Envisager,
            Constants.VerbDescriptions.Regular.Er.Envisager);
    }

    #endregion
}

