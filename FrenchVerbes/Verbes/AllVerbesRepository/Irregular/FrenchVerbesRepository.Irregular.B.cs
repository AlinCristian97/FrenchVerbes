using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularBVerbs()
    {
        _verbs.Add(CreateBoire());
    }

    #region FactoryMethods

    private static IrregularFrenchVerb CreateBoire()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Boire,
            description: Constants.VerbDescriptions.Irregular.Boire,
            pastParticiple: "bu",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "bois",
                [Constants.Pronouns.Tu] = "bois",
                [Constants.Pronouns.IlElleOn] = "boit",
                [Constants.Pronouns.Nous] = "buvons",
                [Constants.Pronouns.Vous] = "buvez",
                [Constants.Pronouns.IlsElles] = "boivent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "bois",
                [Constants.Pronouns.Nous] = "buvons",
                [Constants.Pronouns.Vous] = "buvez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "buv",
                [Constants.Tenses.FuturSimple] = "boir",
                [Constants.Tenses.ConditionnelPresent] = "boir"
            },
            isModal: false,
            supportsProgressive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent exprime l'action de boire maintenant ou habituellement : 'Je bois de l'eau tous les jours.'",
                PasseComposeNotes = "Le passé composé indique une action de boire achevée : 'J'ai bu un café ce matin.'",
                FuturSimpleNotes = "Le futur exprime ce que l'on boira plus tard : 'Tu boiras un verre ce soir.'",
                ConditionnelPresentNotes = "Le conditionnel exprime une action hypothétique ou polie : 'Je boirais un café si j'avais le temps.'",
                ImperativeNotes = "L'impératif sert à donner des instructions ou conseils : 'Bois de l'eau !', 'Buvons ensemble !', 'Buvez avec modération !'"
            }
        );
    }

    #endregion
}