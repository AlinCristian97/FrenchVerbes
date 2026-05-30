using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErGVerbs()
    {
        _verbs.Add(CreateGesticuler());
    }

    #region FactoryMethods

    private static RegularErVerb CreateGesticuler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Gesticuler,
            Constants.VerbDescriptions.Regular.Er.Gesticuler);
    }

    #endregion
}

