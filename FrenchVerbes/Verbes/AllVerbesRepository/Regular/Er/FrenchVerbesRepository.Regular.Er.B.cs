using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErBVerbs()
    {
        _verbs.Add(CreateBeneficier());
    }

    #region FactoryMethods

    private static RegularErVerb CreateBeneficier()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Beneficier,
            Constants.VerbDescriptions.Regular.Er.Beneficier);
    }

    #endregion
}

