using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErIVerbs()
    {
        _verbs.Add(CreateImposer());
    }

    #region FactoryMethods

    private static RegularErVerb CreateImposer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Imposer,
            Constants.VerbDescriptions.Regular.Er.Imposer);
    }

    #endregion
}

