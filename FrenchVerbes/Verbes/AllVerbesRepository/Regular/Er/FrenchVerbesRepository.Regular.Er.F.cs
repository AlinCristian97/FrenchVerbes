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
        _verbs.Add(CreateForger());
        _verbs.Add(CreateSeForger());
        _verbs.Add(CreateFormer());
        _verbs.Add(CreateFermer());
        _verbs.Add(CreateFreiner());
        _verbs.Add(CreateFabriquer());
        _verbs.Add(CreateFeter());
        _verbs.Add(CreateFixer());
        _verbs.Add(CreateFigurer());
        _verbs.Add(CreateFlotter());
        _verbs.Add(CreateFrapper());
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

    private static RegularErVerb CreateForger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Forger,
            Constants.VerbDescriptions.Regular.Er.Forger,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSeForger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Forger,
            Constants.VerbDescriptions.Regular.Er.Se_Forger,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateFormer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Former,
            Constants.VerbDescriptions.Regular.Er.Former);
    }

    private static RegularErVerb CreateFermer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Fermer,
            Constants.VerbDescriptions.Regular.Er.Fermer);
    }

    private static RegularErVerb CreateFreiner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Freiner,
            Constants.VerbDescriptions.Regular.Er.Freiner);
    }

    private static RegularErVerb CreateFabriquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Fabriquer,
            Constants.VerbDescriptions.Regular.Er.Fabriquer);
    }

    private static RegularErVerb CreateFeter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Feter,
            Constants.VerbDescriptions.Regular.Er.Feter);
    }

    private static RegularErVerb CreateFixer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Fixer,
            Constants.VerbDescriptions.Regular.Er.Fixer);
    }

    private static RegularErVerb CreateFigurer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Figurer,
            Constants.VerbDescriptions.Regular.Er.Figurer);
    }

    private static RegularErVerb CreateFlotter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Flotter,
            Constants.VerbDescriptions.Regular.Er.Flotter);
    }

    private static RegularErVerb CreateFrapper()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Frapper,
            Constants.VerbDescriptions.Regular.Er.Frapper);
    }

    #endregion
}

