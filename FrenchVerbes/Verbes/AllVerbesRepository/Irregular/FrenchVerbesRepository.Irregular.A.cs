using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularAVerbs()
    {
        _verbs.Add(CreateAvoir());
        _verbs.Add(CreateAtteindre());
        _verbs.Add(CreateAller());
    }

    #region FactoryMethods

    private static IrregularFrenchVerb CreateAvoir()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Avoir,
            description: Constants.VerbDescriptions.Irregular.Avoir,
            pastParticiple: "eu",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "ai",
                [Constants.Pronouns.Tu] = "as",
                [Constants.Pronouns.IlElleOn] = "a",
                [Constants.Pronouns.Nous] = "avons",
                [Constants.Pronouns.Vous] = "avez",
                [Constants.Pronouns.IlsElles] = "ont"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "aie",
                [Constants.Pronouns.Nous] = "ayons",
                [Constants.Pronouns.Vous] = "ayez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "av",
                [Constants.Tenses.FuturSimple] = "aur",
                [Constants.Tenses.ConditionnelPresent] = "aur"
            },
            supportsProgressive: false,
            tensesNotes: new NotesObject
            {
                ImperativeNotes = "C'est grammaticalement correct, mais son usage est très rare dans la langue parlée.",
                PasseRecentNotes = "Grammaticalement correct, mais cela décrit un état, pas un événement récent."
            }
        );
    }

    private static IrregularFrenchVerb CreateAtteindre()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Atteindre,
            description: Constants.VerbDescriptions.Irregular.Atteindre,
            pastParticiple: "atteint",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "atteins",
                [Constants.Pronouns.Tu] = "atteins",
                [Constants.Pronouns.IlElleOn] = "atteint",
                [Constants.Pronouns.Nous] = "atteignons",
                [Constants.Pronouns.Vous] = "atteignez",
                [Constants.Pronouns.IlsElles] = "atteignent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "atteins",
                [Constants.Pronouns.Nous] = "atteignons",
                [Constants.Pronouns.Vous] = "atteignez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "atteign",
                [Constants.Tenses.FuturSimple] = "atteindr",
                [Constants.Tenses.ConditionnelPresent] = "atteindr"
            },
            isModal: false,
            supportsProgressive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent exprime l'action d'atteindre un objectif ou un point précis : 'J'atteins mon but.'",
                PasseComposeNotes = "Le passé composé indique qu'un objectif a été atteint : 'Nous avons atteint la destination.'",
                FuturSimpleNotes = "Le futur exprime un objectif à atteindre plus tard : 'Il atteindra le sommet demain.'",
                ConditionnelPresentNotes = "Le conditionnel exprime une action hypothétique : 'J'atteindrais mon objectif avec plus de temps.'",
                ImperativeNotes = "L'impératif sert à encourager ou donner des instructions : 'Atteins ton objectif !', 'Atteignons le but !', 'Atteignez la destination !'"
            }
        );
    }

    private static IrregularFrenchVerb CreateAller()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Aller,
            description: Constants.VerbDescriptions.Irregular.Aller,
            pastParticiple: "allé",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "vais",
                [Constants.Pronouns.Tu] = "vas",
                [Constants.Pronouns.IlElleOn] = "va",
                [Constants.Pronouns.Nous] = "allons",
                [Constants.Pronouns.Vous] = "allez",
                [Constants.Pronouns.IlsElles] = "vont"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "va",
                [Constants.Pronouns.Nous] = "allons",
                [Constants.Pronouns.Vous] = "allez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "all",
                [Constants.Tenses.FuturSimple] = "ir",
                [Constants.Tenses.ConditionnelPresent] = "ir"
            },
            usesEtre: true,
            supportsProgressive: false
        );
    }

    #endregion
}