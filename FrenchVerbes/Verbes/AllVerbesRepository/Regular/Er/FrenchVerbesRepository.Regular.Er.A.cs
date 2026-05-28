using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErAVerbs()
    {
        _verbs.Add(CreateAtteler());
        _verbs.Add(CreateApaiser());
        _verbs.Add(CreateApprouver());
        _verbs.Add(CreateAcheter());
        _verbs.Add(CreateAdapter());
        _verbs.Add(CreateAimer());
        _verbs.Add(CreateAllumer());
        _verbs.Add(CreateAppeler());
        _verbs.Add(CreateArriver());
        _verbs.Add(CreateAccrocher());
        _verbs.Add(CreateAnnoncer());
        _verbs.Add(CreateActionner());
        _verbs.Add(CreateAxer());
        _verbs.Add(CreateSe_Axer());
        _verbs.Add(CreateAborder());
        _verbs.Add(CreateAttirer());
        _verbs.Add(CreateAchever());
        _verbs.Add(CreateSe_Achever());
        _verbs.Add(CreateAdopter());
        _verbs.Add(CreateAffronter());
        _verbs.Add(CreateSe_Affronter());
        _verbs.Add(CreateAviser());
        _verbs.Add(CreateAccuser());
        _verbs.Add(CreateSe_Accuser());
        _verbs.Add(CreateAboyer());
        _verbs.Add(CreateAvouer());
        _verbs.Add(CreateApostropher());
        _verbs.Add(CreateAsséner());
        _verbs.Add(CreateAttacher());
        _verbs.Add(CreateSe_Attacher());
        _verbs.Add(CreateApprocher());
        _verbs.Add(CreateSe_Approcher());
        _verbs.Add(CreateAjouter());
        _verbs.Add(CreateAbandonner());
        _verbs.Add(CreateAnnuler());
        _verbs.Add(CreateActiver());
    }

    #region FactoryMethods

    private static RegularErVerb CreateAtteler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Atteler,
            Constants.VerbDescriptions.Regular.Er.Atteler,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Au présent, le 'l' se double sauf à la 1re et 2e personne du pluriel : j'attelle, tu attelles, il attelle, mais nous attelons, vous atelez.",
                FuturSimpleNotes = "Au futur et au conditionnel, le 'l' se double pour toutes les personnes : j'attellerai, j'attellerais."
            });
    }

    private static RegularErVerb CreateAcheter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Acheter,
            Constants.VerbDescriptions.Regular.Er.Acheter,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Acheter change de radical au présent pour certaines personnes : j'achète, tu achètes, il achète, mais nous achetons.",
                FuturSimpleNotes = "Au futur et au conditionnel, acheter utilise le radical 'achèter-' : j'achèterai, j'achèterais."
            });
    }

    private static RegularErVerb CreateActiver()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Activer,
            Constants.VerbDescriptions.Regular.Er.Activer);
    }

    private static RegularErVerb CreateAdapter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Adapter,
            Constants.VerbDescriptions.Regular.Er.Adapter);
    }

    private static RegularErVerb CreateAimer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Aimer,
            Constants.VerbDescriptions.Regular.Er.Aimer);
    }

    private static RegularErVerb CreateAllumer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Allumer,
            Constants.VerbDescriptions.Regular.Er.Allumer);
    }

    private static RegularErVerb CreateAppeler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Appeler,
            Constants.VerbDescriptions.Regular.Er.Appeler,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Au présent, le 'l' se double pour certaines personnes : j'appelle, tu appelles, il/elle appelle, mais nous appelons, vous appelez.",
                FuturSimpleNotes = "Au futur et au conditionnel, le radical prend également un 'l' doublé : j'appellerai, je appellerais."
            });
    }

    private static RegularErVerb CreateApaiser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Apaiser,
            Constants.VerbDescriptions.Regular.Er.Apaiser);
    }

    private static RegularErVerb CreateArriver()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Arriver,
            Constants.VerbDescriptions.Regular.Er.Arriver,
            usesEtre: true,
            tensesNotes: new NotesObject
            {
                PasseComposeNotes = "Arriver se conjugue avec l'auxiliaire 'être' au passé composé : je suis arrivé(e). Le participe passé s'accorde en genre et en nombre avec le sujet.",
                PresentNotes = "Arriver est régulier au présent : j'arrive, tu arrives, il/elle arrive, nous arrivons, vous arrivez, ils/elles arrivent."
            });
    }

    private static RegularErVerb CreateApprouver()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Approuver,
            Constants.VerbDescriptions.Regular.Er.Approuver);
    }

    private static RegularErVerb CreateAccrocher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Accrocher,
            Constants.VerbDescriptions.Regular.Er.Accrocher);
    }

    private static RegularErVerb CreateAnnoncer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Annoncer,
            Constants.VerbDescriptions.Regular.Er.Annoncer,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Annoncer prend une cédille à la 1re personne du singulier du présent pour conserver le son [s] : j'annonce, mais nous annonçons.",
                ImparfaitNotes = "À l'imparfait, le 'c' devient 'ç' à la 1re et 2e personne du pluriel : nous annoncions, vous annonciez — mais ici le son [s] est naturellement préservé par le 'i'."
            });
    }

    private static RegularErVerb CreateActionner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Actionner,
            Constants.VerbDescriptions.Regular.Er.Actionner);
    }

    private static RegularErVerb CreateAxer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Axer,
            Constants.VerbDescriptions.Regular.Er.Axer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Axer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Axer,
            Constants.VerbDescriptions.Regular.Er.Se_Axer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateAborder()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Aborder,
            Constants.VerbDescriptions.Regular.Er.Aborder);
    }

    private static RegularErVerb CreateAttirer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Attirer,
            Constants.VerbDescriptions.Regular.Er.Attirer);
    }

    private static RegularErVerb CreateAchever()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Achever,
            Constants.VerbDescriptions.Regular.Er.Achever,
            hasReflexive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Achever change de radical au présent pour certaines personnes : j'achève, tu achèves, il achève, mais nous achevons, vous achevez.",
                FuturSimpleNotes = "Au futur et au conditionnel, achever utilise le radical 'achèver-' : j'achèverai, j'achèverais."
            });
    }

    private static RegularErVerb CreateSe_Achever()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Achever,
            Constants.VerbDescriptions.Regular.Er.Se_Achever,
            usesEtre: true,
            isReflexive: true,
            tensesNotes: new NotesObject
            {
                PasseComposeNotes = "S'achever s'emploie le plus souvent avec des sujets inanimés : « La réunion s'est achevée », « Le spectacle s'est achevé ». L'usage avec un sujet personnel (je me suis achevé…) est grammaticalement correct mais très rare, limité à des contextes stylistiques ou abstraits.",
                PasseRecentNotes = "Même observation qu'au passé composé : s'achever s'utilise quasi exclusivement avec des sujets inanimés en usage courant. Les formes personnelles (je viens de m'achever…) sont grammaticalement possibles mais extrêmement rares.",
                ImperativeNotes = "Les formes impératives réfléchies (achève-toi, achevons-nous, achevez-vous) sont grammaticalement possibles mais sémantiquement très insolites : s'achever exprime une fin naturelle et ne s'emploie pas comme un ordre adressé à une personne. En pratique, on préfère : « Que le débat s'achève ! », « Que la réunion s'achève ! »."
            });
    }

    private static RegularErVerb CreateAdopter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Adopter,
            Constants.VerbDescriptions.Regular.Er.Adopter);
    }

    private static RegularErVerb CreateAffronter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Affronter,
            Constants.VerbDescriptions.Regular.Er.Affronter,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Affronter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Affronter,
            Constants.VerbDescriptions.Regular.Er.Se_Affronter,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateAviser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Aviser,
            Constants.VerbDescriptions.Regular.Er.Aviser,
            hasReflexive: true);
    }

    private static RegularErVerb CreateAccuser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Accuser,
            Constants.VerbDescriptions.Regular.Er.Accuser,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Accuser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Accuser,
            Constants.VerbDescriptions.Regular.Er.Se_Accuser,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateAboyer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Aboyer,
            Constants.VerbDescriptions.Regular.Er.Aboyer,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Aboyer change de radical au présent : le 'y' devient 'i' devant une terminaison muette — j'aboie, tu aboies, il aboie, ils aboient — mais nous aboyons, vous aboyez.",
                FuturSimpleNotes = "Au futur et au conditionnel, le 'y' devient 'i' pour toutes les personnes : j'aboierai, j'aboierais."
            });
    }

    private static RegularErVerb CreateAvouer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Avouer,
            Constants.VerbDescriptions.Regular.Er.Avouer);
    }

    private static RegularErVerb CreateApostropher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Apostropher,
            Constants.VerbDescriptions.Regular.Er.Apostropher);
    }

    private static RegularErVerb CreateAsséner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Asséner,
            Constants.VerbDescriptions.Regular.Er.Asséner,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Asséner change de radical au présent devant une terminaison muette : j'assène, tu assènes, il assène, ils assènent — mais nous assénons, vous assénez.",
                FuturSimpleNotes = "Au futur et au conditionnel, le radical conserve l'accent aigu : j'assénerai, j'assénerais."
            });
    }

    private static RegularErVerb CreateAttacher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Attacher,
            Constants.VerbDescriptions.Regular.Er.Attacher,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Attacher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Attacher,
            Constants.VerbDescriptions.Regular.Er.Se_Attacher,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateApprocher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Approcher,
            Constants.VerbDescriptions.Regular.Er.Approcher,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Approcher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Approcher,
            Constants.VerbDescriptions.Regular.Er.Se_Approcher,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateAjouter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Ajouter,
            Constants.VerbDescriptions.Regular.Er.Ajouter);
    }

    private static RegularErVerb CreateAbandonner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Abandonner,
            Constants.VerbDescriptions.Regular.Er.Abandonner);
    }

    private static RegularErVerb CreateAnnuler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Annuler,
            Constants.VerbDescriptions.Regular.Er.Annuler);
    }

    #endregion
}

