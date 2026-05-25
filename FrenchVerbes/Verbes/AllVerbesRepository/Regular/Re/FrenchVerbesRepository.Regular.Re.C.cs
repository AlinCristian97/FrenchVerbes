using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularReCVerbs()
    {
        _verbs.Add(CreateComprendre());
        _verbs.Add(CreateConfondre());
    }

    #region FactoryMethods



    #endregion
}
