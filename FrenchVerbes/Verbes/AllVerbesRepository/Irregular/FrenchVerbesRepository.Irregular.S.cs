using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularSVerbs()
    {
        _verbs.Add(CreateSavoir());
    }

    #region FactoryMethods

    private static IrregularFrenchVerb CreateSavoir()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Savoir,
            description: Constants.VerbDescriptions.Irregular.Savoir,
            pastParticiple: "su",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "sais",
                [Constants.Pronouns.Tu] = "sais",
                [Constants.Pronouns.IlElleOn] = "sait",
                [Constants.Pronouns.Nous] = "savons",
                [Constants.Pronouns.Vous] = "savez",
                [Constants.Pronouns.IlsElles] = "savent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "sache",
                [Constants.Pronouns.Nous] = "sachons",
                [Constants.Pronouns.Vous] = "sachez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "sav",
                [Constants.Tenses.FuturSimple] = "saur",
                [Constants.Tenses.ConditionnelPresent] = "saur"
            },
            isModal: true,
            supportsProgressive: false,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent exprime la connaissance ou la capacité actuelle : 'Je sais répondre à cette question.'",
                PasseComposeNotes = "Le passé composé indique qu'une connaissance ou compétence a été acquise : 'J'ai su la vérité hier.'",
                FuturSimpleNotes = "Le futur exprime qu'on saura quelque chose ou pourra faire quelque chose dans l'avenir : 'Tu sauras gérer cette situation demain.'",
                ConditionnelPresentNotes = "Le conditionnel exprime une connaissance ou capacité hypothétique ou polie : 'Vous sauriez répondre si vous étiez informés.'",
                ImperativeNotes = "L'impératif est utilisé pour donner des instructions ou conseils concernant la connaissance : 'Sache la vérité !', 'Sachez respecter les règles !'. C'est grammaticalement correct, mais son usage est très rare dans la langue parlée.",
                PasseRecentNotes = "Grammaticalement correct, mais le savoir n’est pas instantané."
            }
        );
    }

    #endregion
}