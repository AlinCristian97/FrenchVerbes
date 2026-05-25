using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularIrBVerbs()
    {
        _verbs.Add(CreateBatir());
    }

    #region FactoryMethods

    private static RegularIrVerb CreateBatir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Batir,
            Constants.VerbDescriptions.Regular.Ir.Batir);
    }

    #endregion
}
