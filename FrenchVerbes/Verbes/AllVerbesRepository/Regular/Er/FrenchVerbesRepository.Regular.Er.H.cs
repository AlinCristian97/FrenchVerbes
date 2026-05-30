using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErHVerbs()
    {
        _verbs.Add(CreateHarceler());
        _verbs.Add(CreateHeurter());
        _verbs.Add(CreateHabiter());
        _verbs.Add(CreateHabituer());
        _verbs.Add(CreateHurler());
        _verbs.Add(CreateHesiter());
        _verbs.Add(CreateHonorer());
        _verbs.Add(CreateHeriter());
        _verbs.Add(CreateHarmoniser());
        _verbs.Add(CreateHapper());
        _verbs.Add(CreateHocher());
        _verbs.Add(CreateHausser());
    }

    #region FactoryMethods

    private static RegularErVerb CreateHarceler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Harceler,
            Constants.VerbDescriptions.Regular.Er.Harceler);
    }

    private static RegularErVerb CreateHeurter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Heurter,
            Constants.VerbDescriptions.Regular.Er.Heurter);
    }

    private static RegularErVerb CreateHabiter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Habiter,
            Constants.VerbDescriptions.Regular.Er.Habiter);
    }

    private static RegularErVerb CreateHabituer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Habituer,
            Constants.VerbDescriptions.Regular.Er.Habituer);
    }

    private static RegularErVerb CreateHurler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Hurler,
            Constants.VerbDescriptions.Regular.Er.Hurler);
    }

    private static RegularErVerb CreateHesiter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Hesiter,
            Constants.VerbDescriptions.Regular.Er.Hesiter);
    }

    private static RegularErVerb CreateHonorer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Honorer,
            Constants.VerbDescriptions.Regular.Er.Honorer);
    }

    private static RegularErVerb CreateHeriter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Heriter,
            Constants.VerbDescriptions.Regular.Er.Heriter);
    }

    private static RegularErVerb CreateHarmoniser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Harmoniser,
            Constants.VerbDescriptions.Regular.Er.Harmoniser);
    }

    private static RegularErVerb CreateHapper()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Happer,
            Constants.VerbDescriptions.Regular.Er.Happer,
            hasReflexive: false);
    }

    private static RegularErVerb CreateHocher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Hocher,
            Constants.VerbDescriptions.Regular.Er.Hocher);
    }

    private static RegularErVerb CreateHausser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Hausser,
            Constants.VerbDescriptions.Regular.Er.Hausser,
            hasReflexive: true);
    }

    #endregion
}

