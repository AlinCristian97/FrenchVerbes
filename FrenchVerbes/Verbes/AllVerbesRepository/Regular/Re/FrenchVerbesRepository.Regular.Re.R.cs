using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularReRVerbs()
    {
        _verbs.Add(CreateRendre());
    }

    #region FactoryMethods

    private static RegularReVerb CreateRendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Rendre,
            Constants.VerbDescriptions.Regular.Re.Rendre);
    }

    #endregion
}

