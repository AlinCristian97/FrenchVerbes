using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErHVerbs()
    {
        _verbs.Add(CreateHabiter());
    }

    #region FactoryMethods

    private static RegularErVerb CreateHabiter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Habiter,
            Constants.VerbDescriptions.Regular.Er.Habiter);
    }

    #endregion
}

