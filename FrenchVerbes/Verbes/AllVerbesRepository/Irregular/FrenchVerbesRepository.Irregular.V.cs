using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularVVerbs()
    {
        _verbs.Add(CreateVenir());
        _verbs.Add(CreateVivre());
        _verbs.Add(CreateVoir());
        _verbs.Add(CreateVouloir());
    }

    #region Factory Methods

    private static IrregularFrenchVerb CreateVenir()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Venir,
            description: Constants.VerbDescriptions.Irregular.Venir,
            pastParticiple: "venu",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "viens",
                [Constants.Pronouns.Tu] = "viens",
                [Constants.Pronouns.IlElleOn] = "vient",
                [Constants.Pronouns.Nous] = "venons",
                [Constants.Pronouns.Vous] = "venez",
                [Constants.Pronouns.IlsElles] = "viennent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "viens",
                [Constants.Pronouns.Nous] = "venons",
                [Constants.Pronouns.Vous] = "venez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "ven",
                [Constants.Tenses.FuturSimple] = "viendr",
                [Constants.Tenses.ConditionnelPresent] = "viendr"
            },
            usesEtre: true,
            isModal: false,
            supportsProgressive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent exprime l'action de venir maintenant ou régulièrement : 'Je viens à la réunion chaque semaine.'",
                PasseComposeNotes = "Le passé composé indique que le mouvement est déjà effectué : 'Je suis venu hier.'",
                FuturSimpleNotes = "Le futur exprime un déplacement à venir : 'Tu viendras demain.'",
                ConditionnelPresentNotes = "Le conditionnel exprime une arrivée hypothétique ou polie : 'Il viendrait si vous l’invitiez.'",
                ImperativeNotes = "L'impératif donne des instructions concernant le mouvement : 'Viens ici !', 'Venez rapidement !'"
            }
        );
    }

    private static IrregularFrenchVerb CreateVivre()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Vivre,
            description: Constants.VerbDescriptions.Irregular.Vivre,
            pastParticiple: "vécu",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "vis",
                [Constants.Pronouns.Tu] = "vis",
                [Constants.Pronouns.IlElleOn] = "vit",
                [Constants.Pronouns.Nous] = "vivons",
                [Constants.Pronouns.Vous] = "vivez",
                [Constants.Pronouns.IlsElles] = "vivent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "vis",
                [Constants.Pronouns.Nous] = "vivons",
                [Constants.Pronouns.Vous] = "vivez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "viv",
                [Constants.Tenses.FuturSimple] = "vivr",
                [Constants.Tenses.ConditionnelPresent] = "vivr"
            },
            usesEtre: false,
            isModal: false,
            supportsProgressive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent de 'vivre' est irrégulier pour je/tu/il/ils : 'je vis', 'il vit', mais 'nous vivons'.",
                PasseComposeNotes = "Le passé composé se forme avec 'avoir' et le participe passé 'vécu' : 'J'ai vécu à Paris.'",
                FuturSimpleNotes = "Le futur utilise le radical 'vivr-' : 'Je vivrai à l'étranger un jour.'",
                ConditionnelPresentNotes = "Le conditionnel exprime une situation hypothétique ou un souhait : 'Je vivrais ailleurs si je pouvais.'",
                ImperativeNotes = "L'impératif de 'vivre' est rare mais possible, souvent avec une valeur expressive : 'Vis pleinement !'"
            }
        );
    }

    private static IrregularFrenchVerb CreateVoir()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Voir,
            description: Constants.VerbDescriptions.Irregular.Voir,
            pastParticiple: "vu",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "vois",
                [Constants.Pronouns.Tu] = "vois",
                [Constants.Pronouns.IlElleOn] = "voit",
                [Constants.Pronouns.Nous] = "voyons",
                [Constants.Pronouns.Vous] = "voyez",
                [Constants.Pronouns.IlsElles] = "voient"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "vois",
                [Constants.Pronouns.Nous] = "voyons",
                [Constants.Pronouns.Vous] = "voyez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "voy",
                [Constants.Tenses.FuturSimple] = "verr",
                [Constants.Tenses.ConditionnelPresent] = "verr"
            },
            isModal: false,
            supportsProgressive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent exprime la perception ou la connaissance actuelle : 'Je vois la situation clairement.'",
                PasseComposeNotes = "Le passé composé indique une action de perception ou de constatation achevée : 'J'ai vu le film hier.'",
                FuturSimpleNotes = "Le futur exprime qu'on percevra ou constatera quelque chose à l'avenir : 'Tu verras le résultat demain.'",
                ConditionnelPresentNotes = "Le conditionnel exprime une perception hypothétique ou polie : 'Il verrait mieux avec des lunettes.'",
                ImperativeNotes = "L'impératif donne des instructions concernant la perception ou l'observation : 'Vois ce qui se passe !', 'Voyez le problème clairement !'"
            }
        );
    }

    private static IrregularFrenchVerb CreateVouloir()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Vouloir,
            description: Constants.VerbDescriptions.Irregular.Vouloir,
            pastParticiple: "voulu",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "veux",
                [Constants.Pronouns.Tu] = "veux",
                [Constants.Pronouns.IlElleOn] = "veut",
                [Constants.Pronouns.Nous] = "voulons",
                [Constants.Pronouns.Vous] = "voulez",
                [Constants.Pronouns.IlsElles] = "veulent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "veuille",
                [Constants.Pronouns.Nous] = "veuillons",
                [Constants.Pronouns.Vous] = "veuillez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "voul",
                [Constants.Tenses.FuturSimple] = "voudr",
                [Constants.Tenses.ConditionnelPresent] = "voudr"
            },
            isModal: true,
            supportsProgressive: false,
            tensesNotes: new NotesObject
            {
                PasseRecentNotes = "Grammaticalement correct, mais le désir n’est pas une action achevée.",
                ImperativeNotes = "'Vouloir' a une forme impérative rare et archaïque. Elle n’est utilisée que dans des expressions figées ou dans un registre littéraire ancien, notamment pour exprimer un ordre solennel ou une injonction formelle, par exemple : 'Veuillez patienter', 'Veuillez agréer…'. En français moderne courant, on évite l’impératif de vouloir et on lui préfère des tournures plus naturelles."
            }
        );
    }

    #endregion

    #region FactoryMethods

    #endregion
}