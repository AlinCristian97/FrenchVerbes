using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErEVerbs()
    {
        _verbs.Add(CreateEnvisager());
        _verbs.Add(CreateExiger());
        _verbs.Add(CreateEngueuler());
        _verbs.Add(CreateEmprisonner());
        _verbs.Add(CreateSe_Emprisonner());
    }

    #region FactoryMethods

    private static RegularErVerb CreateEnvisager()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Envisager,
            Constants.VerbDescriptions.Regular.Er.Envisager);
    }

    private static RegularErVerb CreateExiger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Exiger,
            Constants.VerbDescriptions.Regular.Er.Exiger);
    }

    private static RegularErVerb CreateEngueuler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Engueuler,
            Constants.VerbDescriptions.Regular.Er.Engueuler);
    }

    private static RegularErVerb CreateEmprisonner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Emprisonner,
            Constants.VerbDescriptions.Regular.Er.Emprisonner,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Emprisonner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Emprisonner,
            Constants.VerbDescriptions.Regular.Er.Se_Emprisonner,
            usesEtre: true,
            isReflexive: true);
    }

    #endregion
}

