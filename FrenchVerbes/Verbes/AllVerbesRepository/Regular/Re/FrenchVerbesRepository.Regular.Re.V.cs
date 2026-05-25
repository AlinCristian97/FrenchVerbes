using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularReVVerbs()
    {
        _verbs.Add(CreateVendre());
    }

    #region FactoryMethods

    private static RegularReVerb CreateVendre()
    {
        return new RegularReVerb(Constants.Verbs.Regular.Re.Vendre, Constants.VerbDescriptions.Regular.Re.Vendre);
    }

    #endregion
}

