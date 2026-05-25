using FrenchVerbes.AllConstants;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularDVerbs()
    {
        _verbs.Add(CreateDevoir());
        _verbs.Add(CreateDire());
    }

    #region FactoryMethods

    #endregion
}



