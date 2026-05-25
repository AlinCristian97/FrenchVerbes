using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErAVerbs()
    {
        _verbs.Add(CreateAcheter());
        _verbs.Add(CreateAdapter());
        _verbs.Add(CreateAimer());
        _verbs.Add(CreateAppeler());
        _verbs.Add(CreateArriver());
    }

    #region FactoryMethods



    #endregion
}
