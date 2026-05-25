using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularReAVerbs()
    {
        _verbs.Add(CreateAttendre());
    }

    #region FactoryMethods

    private static RegularReVerb CreateAttendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Attendre,
            Constants.VerbDescriptions.Regular.Re.Attendre);
    }

    #endregion
}

