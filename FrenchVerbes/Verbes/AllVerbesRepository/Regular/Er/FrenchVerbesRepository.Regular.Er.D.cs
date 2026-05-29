using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErDVerbs()
    {
        _verbs.Add(CreateDenaturer());
        _verbs.Add(CreateDefigurer());
        _verbs.Add(CreateDeranger());
    }

    #region FactoryMethods

    private static RegularErVerb CreateDenaturer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Denaturer,
            Constants.VerbDescriptions.Regular.Er.Denaturer);
    }

    private static RegularErVerb CreateDefigurer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Defigurer,
            Constants.VerbDescriptions.Regular.Er.Defigurer);
    }

    private static RegularErVerb CreateDeranger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Deranger,
            Constants.VerbDescriptions.Regular.Er.Deranger);
    }

    #endregion
}

