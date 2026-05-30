using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErFVerbs()
    {
        _verbs.Add(CreateFacher());
        _verbs.Add(CreateForcer());
        _verbs.Add(CreateSeForcer());
        _verbs.Add(CreateFrequenter());
        _verbs.Add(CreateFissurer());
    }

    #region FactoryMethods

    private static RegularErVerb CreateFacher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Facher,
            Constants.VerbDescriptions.Regular.Er.Facher);
    }

    private static RegularErVerb CreateForcer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Forcer,
            Constants.VerbDescriptions.Regular.Er.Forcer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSeForcer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Forcer,
            Constants.VerbDescriptions.Regular.Er.Se_Forcer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateFrequenter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Frequenter,
            Constants.VerbDescriptions.Regular.Er.Frequenter);
    }

    private static RegularErVerb CreateFissurer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Fissurer,
            Constants.VerbDescriptions.Regular.Er.Fissurer);
    }

    #endregion
}

