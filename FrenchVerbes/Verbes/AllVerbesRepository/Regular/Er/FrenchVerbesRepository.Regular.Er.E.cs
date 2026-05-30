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
        _verbs.Add(CreateEclairer());
        _verbs.Add(CreateExploser());
        _verbs.Add(CreateExperimenter());
        _verbs.Add(CreateEquiper());
        _verbs.Add(CreateSe_Equiper());
        _verbs.Add(CreateEcouter());
        _verbs.Add(CreateEnnuyer());
        _verbs.Add(CreateSe_Ennuyer());
        _verbs.Add(CreateEmpecher());
        _verbs.Add(CreateEnerver());
        _verbs.Add(CreateSe_Enerver());
        _verbs.Add(CreateEntrer());
        _verbs.Add(CreateEparpiller());
        _verbs.Add(CreateEsperer());
        _verbs.Add(CreateEssayer());
        _verbs.Add(CreateEtudier());
        _verbs.Add(CreateExpliquer());
        _verbs.Add(CreateExister());
        _verbs.Add(CreateExaminer());
        _verbs.Add(CreateExercer());
        _verbs.Add(CreateExagerer());
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

    private static RegularErVerb CreateEclairer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Eclairer,
            Constants.VerbDescriptions.Regular.Er.Eclairer);
    }

    private static RegularErVerb CreateExploser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Exploser,
            Constants.VerbDescriptions.Regular.Er.Exploser);
    }

    private static RegularErVerb CreateExperimenter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Experimenter,
            Constants.VerbDescriptions.Regular.Er.Experimenter);
    }

    private static RegularErVerb CreateEquiper()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Equiper,
            Constants.VerbDescriptions.Regular.Er.Equiper,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Equiper()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Equiper,
            Constants.VerbDescriptions.Regular.Er.Se_Equiper,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEcouter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Ecouter,
            Constants.VerbDescriptions.Regular.Er.Ecouter);
    }

    private static RegularErVerb CreateEnnuyer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Ennuyer,
            Constants.VerbDescriptions.Regular.Er.Ennuyer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Ennuyer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Ennuyer,
            Constants.VerbDescriptions.Regular.Er.Se_Ennuyer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEmpecher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Empecher,
            Constants.VerbDescriptions.Regular.Er.Empecher);
    }

    private static RegularErVerb CreateEnerver()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Enerver,
            Constants.VerbDescriptions.Regular.Er.Enerver,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Enerver()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Enerver,
            Constants.VerbDescriptions.Regular.Er.Se_Enerver,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEntrer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Entrer,
            Constants.VerbDescriptions.Regular.Er.Entrer,
            usesEtre: true);
    }

    private static RegularErVerb CreateEparpiller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Eparpiller,
            Constants.VerbDescriptions.Regular.Er.Eparpiller);
    }

    private static RegularErVerb CreateEsperer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Esperer,
            Constants.VerbDescriptions.Regular.Er.Esperer);
    }

    private static RegularErVerb CreateEssayer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Essayer,
            Constants.VerbDescriptions.Regular.Er.Essayer);
    }

    private static RegularErVerb CreateEtudier()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Etudier,
            Constants.VerbDescriptions.Regular.Er.Etudier);
    }

    private static RegularErVerb CreateExpliquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Expliquer,
            Constants.VerbDescriptions.Regular.Er.Expliquer);
    }

    private static RegularErVerb CreateExister()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Exister,
            Constants.VerbDescriptions.Regular.Er.Exister,
            tensesNotes: new NotesObject
            {
                PasseRecentNotes = "Le passé récent ne s'applique pas à « exister » — on n'utilise pas « venir d'exister »."
            });
    }

    private static RegularErVerb CreateExaminer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Examiner,
            Constants.VerbDescriptions.Regular.Er.Examiner);
    }

    private static RegularErVerb CreateExercer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Exercer,
            Constants.VerbDescriptions.Regular.Er.Exercer);
    }

    private static RegularErVerb CreateExagerer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Exagerer,
            Constants.VerbDescriptions.Regular.Er.Exagerer);
    }

    #endregion
}

