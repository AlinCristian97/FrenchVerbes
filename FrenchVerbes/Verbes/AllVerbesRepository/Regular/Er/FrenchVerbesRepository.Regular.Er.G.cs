using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErGVerbs()
    {
        _verbs.Add(CreateGesticuler());
        _verbs.Add(CreateGener());
        _verbs.Add(CreateSeGener());
        _verbs.Add(CreateGrincer());
    }

    #region FactoryMethods

    private static RegularErVerb CreateGesticuler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Gesticuler,
            Constants.VerbDescriptions.Regular.Er.Gesticuler);
    }

    private static RegularErVerb CreateGener()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Gener,
            Constants.VerbDescriptions.Regular.Er.Gener,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSeGener()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Gener,
            Constants.VerbDescriptions.Regular.Er.Se_Gener,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateGrincer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Grincer,
            Constants.VerbDescriptions.Regular.Er.Grincer);
    }

    #endregion
}

