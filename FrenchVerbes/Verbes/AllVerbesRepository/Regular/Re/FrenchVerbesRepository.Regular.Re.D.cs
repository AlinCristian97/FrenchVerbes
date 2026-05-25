using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularReDVerbs()
    {
        _verbs.Add(CreateDefendre());
        _verbs.Add(CreateDescendre());
    }

    #region FactoryMethods



    #endregion
}
