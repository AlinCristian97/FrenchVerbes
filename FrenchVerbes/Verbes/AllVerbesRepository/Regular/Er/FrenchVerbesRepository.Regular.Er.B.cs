using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErBVerbs()
    {
        _verbs.Add(CreateBeneficier());
        _verbs.Add(CreateBriller());
        _verbs.Add(CreateBombarder());
    }

    #region FactoryMethods

    private static RegularErVerb CreateBeneficier()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Beneficier,
            Constants.VerbDescriptions.Regular.Er.Beneficier);
    }

    private static RegularErVerb CreateBriller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Briller,
            Constants.VerbDescriptions.Regular.Er.Briller);
    }

    private static RegularErVerb CreateBombarder()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Bombarder,
            Constants.VerbDescriptions.Regular.Er.Bombarder);
    }

    #endregion
}

