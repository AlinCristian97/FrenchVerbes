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
        _verbs.Add(CreateGratifier());
        _verbs.Add(CreateGratter());
        _verbs.Add(CreateGuider());
        _verbs.Add(CreateGerer());
        _verbs.Add(CreateGenerer());
        _verbs.Add(CreateGonfler());
        _verbs.Add(CreateGriffonner());
        _verbs.Add(CreateGeler());
        _verbs.Add(CreateGlacer());
        _verbs.Add(CreateGriller());
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

    private static RegularErVerb CreateGratifier()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Gratifier,
            Constants.VerbDescriptions.Regular.Er.Gratifier);
    }

    private static RegularErVerb CreateGratter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Gratter,
            Constants.VerbDescriptions.Regular.Er.Gratter);
    }

    private static RegularErVerb CreateGuider()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Guider,
            Constants.VerbDescriptions.Regular.Er.Guider);
    }

    private static RegularErVerb CreateGerer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Gerer,
            Constants.VerbDescriptions.Regular.Er.Gerer);
    }

    private static RegularErVerb CreateGenerer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Generer,
            Constants.VerbDescriptions.Regular.Er.Generer);
    }

    private static RegularErVerb CreateGonfler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Gonfler,
            Constants.VerbDescriptions.Regular.Er.Gonfler);
    }

    private static RegularErVerb CreateGriffonner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Griffonner,
            Constants.VerbDescriptions.Regular.Er.Griffonner);
    }

    private static RegularErVerb CreateGeler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Geler,
            Constants.VerbDescriptions.Regular.Er.Geler);
    }

    private static RegularErVerb CreateGlacer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Glacer,
            Constants.VerbDescriptions.Regular.Er.Glacer);
    }

    private static RegularErVerb CreateGriller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Griller,
            Constants.VerbDescriptions.Regular.Er.Griller);
    }

    #endregion
}

