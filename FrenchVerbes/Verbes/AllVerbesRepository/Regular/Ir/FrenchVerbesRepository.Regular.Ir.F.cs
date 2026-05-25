using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularIrFVerbs()
    {
        _verbs.Add(CreateFinir());
    }

    #region FactoryMethods

    private static RegularIrVerb CreateFinir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Finir,
            Constants.VerbDescriptions.Regular.Ir.Finir);
    }

    #endregion
}
