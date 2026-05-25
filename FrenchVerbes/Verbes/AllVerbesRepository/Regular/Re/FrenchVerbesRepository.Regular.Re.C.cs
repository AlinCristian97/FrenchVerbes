using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularReCVerbs()
    {
        _verbs.Add(CreateComprendre());
        _verbs.Add(CreateConfondre());
    }

    #region FactoryMethods

    private static RegularReVerb CreateComprendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Comprendre,
            Constants.VerbDescriptions.Regular.Re.Comprendre);
    }

    private static RegularReVerb CreateConfondre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Confondre,
            Constants.VerbDescriptions.Regular.Re.Confondre);
    }

    #endregion
}

