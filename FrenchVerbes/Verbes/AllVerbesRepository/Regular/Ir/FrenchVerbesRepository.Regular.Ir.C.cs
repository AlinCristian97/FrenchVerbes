using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularIrCVerbs()
    {
        _verbs.Add(CreateChoisir());
    }

    #region FactoryMethods

    private static RegularIrVerb CreateChoisir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Choisir,
            Constants.VerbDescriptions.Regular.Ir.Choisir);
    }

    #endregion
}
