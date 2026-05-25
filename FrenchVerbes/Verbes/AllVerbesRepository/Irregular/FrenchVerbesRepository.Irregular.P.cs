using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularPVerbs()
    {
        _verbs.Add(CreatePouvoir());
        _verbs.Add(CreatePrendre());
    }

    #region FactoryMethods

    private static IrregularFrenchVerb CreatePouvoir()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Pouvoir,
            description: Constants.VerbDescriptions.Irregular.Pouvoir,
            pastParticiple: "pu",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "peux",
                [Constants.Pronouns.Tu] = "peux",
                [Constants.Pronouns.IlElleOn] = "peut",
                [Constants.Pronouns.Nous] = "pouvons",
                [Constants.Pronouns.Vous] = "pouvez",
                [Constants.Pronouns.IlsElles] = "peuvent"
            },
            imperative: null, // Pouvoir has no imperative form (modal verb)
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "pouv",
                [Constants.Tenses.FuturSimple] = "pourr",
                [Constants.Tenses.ConditionnelPresent] = "pourr"
            },
            isModal: true,
            supportsProgressive: false,
            tensesNotes: new NotesObject
            {
                ImperativeNotes = "C'est grammaticalement correct, mais son usage est très rare dans la langue parlée.",
                PasseRecentNotes = "Grammaticalement correct, mais la capacité n’est pas une action ponctuelle."
            }
        );
    }

    private static IrregularFrenchVerb CreatePrendre()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Prendre,
            description: Constants.VerbDescriptions.Irregular.Prendre,
            pastParticiple: "pris",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "prends",
                [Constants.Pronouns.Tu] = "prends",
                [Constants.Pronouns.IlElleOn] = "prend",
                [Constants.Pronouns.Nous] = "prenons",
                [Constants.Pronouns.Vous] = "prenez",
                [Constants.Pronouns.IlsElles] = "prennent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "prends",
                [Constants.Pronouns.Nous] = "prenons",
                [Constants.Pronouns.Vous] = "prenez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "pren",
                [Constants.Tenses.FuturSimple] = "prendr",
                [Constants.Tenses.ConditionnelPresent] = "prendr"
            },
            isModal: false,
            supportsProgressive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent exprime l'action de saisir, obtenir ou consommer actuellement : 'Je prends un café.'",
                PasseComposeNotes = "Le passé composé indique que l'action a été accomplie : 'J'ai pris le train ce matin.'",
                FuturSimpleNotes = "Le futur exprime ce que l'on prendra ou obtiendra : 'Tu prendras ta décision demain.'",
                ConditionnelPresentNotes = "Le conditionnel exprime ce que l'on prendrait dans un contexte hypothétique : 'Il prendrait un jour de congé si possible.'",
                ImperativeNotes = "L'impératif donne des instructions pour prendre ou saisir quelque chose : 'Prends ton temps !', 'Prenons cette décision ensemble !', 'Prenez ce livre !'"
            }
        );
    }

    #endregion
}