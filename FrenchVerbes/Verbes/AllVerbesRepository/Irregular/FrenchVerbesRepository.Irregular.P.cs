using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularPVerbs()
    {
        _verbs.Add(CreatePouvoir());
        _verbs.Add(CreatePrendre());
    }

    #region FactoryMethods

    #endregion
}



