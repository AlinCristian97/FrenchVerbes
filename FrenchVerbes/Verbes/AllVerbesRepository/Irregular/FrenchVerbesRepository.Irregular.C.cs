using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularCVerbs()
    {
        _verbs.Add(CreateConduire());
        _verbs.Add(CreateCourir());
    }

    #region FactoryMethods

    private static IrregularFrenchVerb CreateConduire()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Conduire,
            description: Constants.VerbDescriptions.Irregular.Conduire,
            pastParticiple: "conduit",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "conduis",
                [Constants.Pronouns.Tu] = "conduis",
                [Constants.Pronouns.IlElleOn] = "conduit",
                [Constants.Pronouns.Nous] = "conduisons",
                [Constants.Pronouns.Vous] = "conduisez",
                [Constants.Pronouns.IlsElles] = "conduisent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "conduis",
                [Constants.Pronouns.Nous] = "conduisons",
                [Constants.Pronouns.Vous] = "conduisez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "conduis",
                [Constants.Tenses.FuturSimple] = "conduir",
                [Constants.Tenses.ConditionnelPresent] = "conduir"
            },
            isModal: false,
            supportsProgressive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent exprime l'action de conduire maintenant ou régulièrement : 'Je conduis la voiture tous les jours.'",
                PasseComposeNotes = "Le passé composé indique que l'action de conduire a été accomplie : 'J'ai conduit jusqu'à la plage.'",
                FuturSimpleNotes = "Le futur exprime ce que l'on conduira dans l'avenir : 'Tu conduiras la voiture demain.'",
                ConditionnelPresentNotes = "Le conditionnel exprime ce qu'on conduirait dans un contexte hypothétique ou poli : 'Il conduirait la voiture si on lui demandait.'",
                ImperativeNotes = "L'impératif donne des instructions concernant la conduite : 'Conduis prudemment !', 'Conduisons ensemble !', 'Conduisez lentement !'"
            }
        );
    }

    private static IrregularFrenchVerb CreateCourir()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Courir,
            description: Constants.VerbDescriptions.Irregular.Courir,
            pastParticiple: "couru",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "cours",
                [Constants.Pronouns.Tu] = "cours",
                [Constants.Pronouns.IlElleOn] = "court",
                [Constants.Pronouns.Nous] = "courons",
                [Constants.Pronouns.Vous] = "courez",
                [Constants.Pronouns.IlsElles] = "courent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "cours",
                [Constants.Pronouns.Nous] = "courons",
                [Constants.Pronouns.Vous] = "courez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "cour",
                [Constants.Tenses.FuturSimple] = "courr",
                [Constants.Tenses.ConditionnelPresent] = "courr"
            },
            isModal: false,
            supportsProgressive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent exprime une action de courir en cours ou habituelle : 'Je cours tous les matins.'",
                PasseComposeNotes = "Le passé composé indique une action de courir terminée : 'Ils ont couru pendant une heure.'",
                FuturSimpleNotes = "Le futur exprime une action à venir : 'Tu courras demain matin.'",
                ConditionnelPresentNotes = "Le conditionnel exprime une action hypothétique : 'Je courrais plus souvent si j'avais le temps.'",
                ImperativeNotes = "L'impératif sert à donner des instructions ou encouragements : 'Cours vite !', 'Courons ensemble !', 'Courez prudemment !'"
            }
        );
    }

    #endregion
}