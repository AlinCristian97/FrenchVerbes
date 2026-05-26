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

    #endregion
}

