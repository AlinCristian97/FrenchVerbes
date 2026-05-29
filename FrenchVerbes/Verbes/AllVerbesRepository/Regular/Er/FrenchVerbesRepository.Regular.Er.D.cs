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
        _verbs.Add(CreateDebloquer());
        _verbs.Add(CreateSe_Debloquer());
        _verbs.Add(CreateDebrouiller());
        _verbs.Add(CreateSe_Debrouiller());
        _verbs.Add(CreateDivaguer());
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

    private static RegularErVerb CreateDebloquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Debloquer,
            Constants.VerbDescriptions.Regular.Er.Debloquer);
    }

    private static RegularErVerb CreateSe_Debloquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Debloquer,
            Constants.VerbDescriptions.Regular.Er.Se_Debloquer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateDebrouiller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Debrouiller,
            Constants.VerbDescriptions.Regular.Er.Debrouiller,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Debrouiller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Debrouiller,
            Constants.VerbDescriptions.Regular.Er.Se_Debrouiller,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateDivaguer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Divaguer,
            Constants.VerbDescriptions.Regular.Er.Divaguer);
    }

    #endregion
}

