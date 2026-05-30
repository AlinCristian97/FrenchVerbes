using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErFVerbs()
    {
        _verbs.Add(CreateFacher());
    }

    #region FactoryMethods

    private static RegularErVerb CreateFacher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Facher,
            Constants.VerbDescriptions.Regular.Er.Facher);
    }

    #endregion
}

