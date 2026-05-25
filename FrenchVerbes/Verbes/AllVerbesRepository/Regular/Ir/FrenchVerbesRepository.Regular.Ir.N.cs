using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularIrNVerbs()
    {
        _verbs.Add(CreateNourrir());
    }

    #region FactoryMethods

    private static RegularIrVerb CreateNourrir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Nourrir,
            Constants.VerbDescriptions.Regular.Ir.Nourrir
        );
    }

    #endregion
}
