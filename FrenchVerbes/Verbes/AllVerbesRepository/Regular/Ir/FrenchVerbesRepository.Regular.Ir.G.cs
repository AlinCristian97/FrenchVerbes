using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularIrGVerbs()
    {
        _verbs.Add(CreateGrandir());
    }

    #region FactoryMethods

    private static RegularIrVerb CreateGrandir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Grandir,
            Constants.VerbDescriptions.Regular.Ir.Grandir);
    }

    #endregion
}
