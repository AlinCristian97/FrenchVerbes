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
        _verbs.Add(CreateExecuter());
        _verbs.Add(CreateEchanger());
        _verbs.Add(CreateEchapper());
        _verbs.Add(CreateSe_Echapper());
        _verbs.Add(CreateElever());
        _verbs.Add(CreateEloigner());
        _verbs.Add(CreateSe_Eloigner());
        _verbs.Add(CreateEmerger());
        _verbs.Add(CreateEpeler());
        _verbs.Add(CreateEpouser());
        _verbs.Add(CreateEprouver());
        _verbs.Add(CreateEviter());
        _verbs.Add(CreateEvoluer());
        _verbs.Add(CreateElaborer());
        _verbs.Add(CreateEmporter());
        _verbs.Add(CreateEmprunter());
        _verbs.Add(CreateEnregistrer());
        _verbs.Add(CreateEnlever());
        _verbs.Add(CreateEcarter());
        _verbs.Add(CreateEnserrer());
        _verbs.Add(CreateEnfiler());
        _verbs.Add(CreateEnsanglanter());
        _verbs.Add(CreateEnfermer());
        _verbs.Add(CreateEgaler());
        _verbs.Add(CreateEntrainer());
        _verbs.Add(CreateSe_Entrainer());
        _verbs.Add(CreateEncadrer());
        _verbs.Add(CreateExcuser());
        _verbs.Add(CreateSe_Excuser());
        _verbs.Add(CreateEmpresser());
        _verbs.Add(CreateSe_Empresser());
        _verbs.Add(CreateEnquiquiner());
        _verbs.Add(CreateSe_Enquiquiner());
        _verbs.Add(CreateEtonner());
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

    private static RegularErVerb CreateExecuter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Executer,
            Constants.VerbDescriptions.Regular.Er.Executer);
    }

    private static RegularErVerb CreateEchanger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Echanger,
            Constants.VerbDescriptions.Regular.Er.Echanger);
    }

    private static RegularErVerb CreateEchapper()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Echapper,
            Constants.VerbDescriptions.Regular.Er.Echapper,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Echapper()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Echapper,
            Constants.VerbDescriptions.Regular.Er.Se_Echapper,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateElever()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Elever,
            Constants.VerbDescriptions.Regular.Er.Elever);
    }

    private static RegularErVerb CreateEloigner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Eloigner,
            Constants.VerbDescriptions.Regular.Er.Eloigner,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Eloigner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Eloigner,
            Constants.VerbDescriptions.Regular.Er.Se_Eloigner,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEmerger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Emerger,
            Constants.VerbDescriptions.Regular.Er.Emerger);
    }

    private static RegularErVerb CreateEpeler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Epeler,
            Constants.VerbDescriptions.Regular.Er.Epeler);
    }

    private static RegularErVerb CreateEpouser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Epouser,
            Constants.VerbDescriptions.Regular.Er.Epouser);
    }

    private static RegularErVerb CreateEprouver()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Eprouver,
            Constants.VerbDescriptions.Regular.Er.Eprouver);
    }

    private static RegularErVerb CreateEviter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Eviter,
            Constants.VerbDescriptions.Regular.Er.Eviter);
    }

    private static RegularErVerb CreateEvoluer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Evoluer,
            Constants.VerbDescriptions.Regular.Er.Evoluer);
    }

    private static RegularErVerb CreateElaborer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Elaborer,
            Constants.VerbDescriptions.Regular.Er.Elaborer);
    }

    private static RegularErVerb CreateEmporter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Emporter,
            Constants.VerbDescriptions.Regular.Er.Emporter);
    }

    private static RegularErVerb CreateEmprunter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Emprunter,
            Constants.VerbDescriptions.Regular.Er.Emprunter);
    }

    private static RegularErVerb CreateEnregistrer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Enregistrer,
            Constants.VerbDescriptions.Regular.Er.Enregistrer);
    }

    private static RegularErVerb CreateEnlever()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Enlever,
            Constants.VerbDescriptions.Regular.Er.Enlever);
    }

    private static RegularErVerb CreateEcarter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Ecarter,
            Constants.VerbDescriptions.Regular.Er.Ecarter);
    }

    private static RegularErVerb CreateEnserrer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Enserrer,
            Constants.VerbDescriptions.Regular.Er.Enserrer);
    }

    private static RegularErVerb CreateEnfiler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Enfiler,
            Constants.VerbDescriptions.Regular.Er.Enfiler);
    }

    private static RegularErVerb CreateEnsanglanter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Ensanglanter,
            Constants.VerbDescriptions.Regular.Er.Ensanglanter);
    }

    private static RegularErVerb CreateEnfermer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Enfermer,
            Constants.VerbDescriptions.Regular.Er.Enfermer);
    }

    private static RegularErVerb CreateEgaler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Egaler,
            Constants.VerbDescriptions.Regular.Er.Egaler);
    }

    private static RegularErVerb CreateEntrainer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Entrainer,
            Constants.VerbDescriptions.Regular.Er.Entrainer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Entrainer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Entrainer,
            Constants.VerbDescriptions.Regular.Er.Se_Entrainer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEncadrer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Encadrer,
            Constants.VerbDescriptions.Regular.Er.Encadrer);
    }

    private static RegularErVerb CreateExcuser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Excuser,
            Constants.VerbDescriptions.Regular.Er.Excuser,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Excuser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Excuser,
            Constants.VerbDescriptions.Regular.Er.Se_Excuser,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEmpresser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Empresser,
            Constants.VerbDescriptions.Regular.Er.Empresser,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Empresser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Empresser,
            Constants.VerbDescriptions.Regular.Er.Se_Empresser,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEnquiquiner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Enquiquiner,
            Constants.VerbDescriptions.Regular.Er.Enquiquiner,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Enquiquiner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Enquiquiner,
            Constants.VerbDescriptions.Regular.Er.Se_Enquiquiner,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateEtonner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Etonner,
            Constants.VerbDescriptions.Regular.Er.Etonner);
    }

    #endregion
}

