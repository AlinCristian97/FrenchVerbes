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
        _verbs.Add(CreateEvoquer());
        _verbs.Add(CreateEmpoisonner());
        _verbs.Add(CreateSe_Empoisonner());
        _verbs.Add(CreateEnflammer());
        _verbs.Add(CreateSe_Enflammer());
        _verbs.Add(CreateEcraser());
        _verbs.Add(CreateSe_Ecraser());
        _verbs.Add(CreateEstimer());
        _verbs.Add(CreateExpedier());
        _verbs.Add(CreateEmbrasser());
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

    private static RegularErVerb CreateEvoquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Evoquer,
            Constants.VerbDescriptions.Regular.Er.Evoquer);
    }

    private static RegularErVerb CreateEmpoisonner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Empoisonner,
            Constants.VerbDescriptions.Regular.Er.Empoisonner,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Empoisonner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Empoisonner,
            Constants.VerbDescriptions.Regular.Er.Se_Empoisonner,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEnflammer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Enflammer,
            Constants.VerbDescriptions.Regular.Er.Enflammer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Enflammer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Enflammer,
            Constants.VerbDescriptions.Regular.Er.Se_Enflammer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEcraser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Ecraser,
            Constants.VerbDescriptions.Regular.Er.Ecraser,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Ecraser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Ecraser,
            Constants.VerbDescriptions.Regular.Er.Se_Ecraser,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEstimer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Estimer,
            Constants.VerbDescriptions.Regular.Er.Estimer);
    }

    private static RegularErVerb CreateExpedier()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Expedier,
            Constants.VerbDescriptions.Regular.Er.Expedier);
    }

    private static RegularErVerb CreateEmbrasser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Embrasser,
            Constants.VerbDescriptions.Regular.Er.Embrasser,
            hasReflexive: true);
    }

    #endregion
}

