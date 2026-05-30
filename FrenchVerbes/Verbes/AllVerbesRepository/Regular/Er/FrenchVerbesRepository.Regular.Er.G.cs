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
        _verbs.Add(CreateGarder());
        _verbs.Add(CreateGagner());
        _verbs.Add(CreateGouter());
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

    private static RegularErVerb CreateGarder()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Garder,
            Constants.VerbDescriptions.Regular.Er.Garder);
    }

    private static RegularErVerb CreateGagner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Gagner,
            Constants.VerbDescriptions.Regular.Er.Gagner);
    }

    private static RegularErVerb CreateGouter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Gouter,
            Constants.VerbDescriptions.Regular.Er.Gouter);
    }

    #endregion
}

