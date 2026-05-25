using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularDVerbs()
    {
        _verbs.Add(CreateDevoir());
        _verbs.Add(CreateDire());
    }

    #region FactoryMethods

    private static IrregularFrenchVerb CreateDevoir()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Devoir,
            description: Constants.VerbDescriptions.Irregular.Devoir,
            pastParticiple: "dû",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "dois",
                [Constants.Pronouns.Tu] = "dois",
                [Constants.Pronouns.IlElleOn] = "doit",
                [Constants.Pronouns.Nous] = "devons",
                [Constants.Pronouns.Vous] = "devez",
                [Constants.Pronouns.IlsElles] = "doivent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "dois",
                [Constants.Pronouns.Nous] = "devons",
                [Constants.Pronouns.Vous] = "devez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "dev",
                [Constants.Tenses.FuturSimple] = "devr",
                [Constants.Tenses.ConditionnelPresent] = "devr"
            },
            isModal: true,
            supportsProgressive: false,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent de 'devoir' exprime la nécessité ou l'obligation immédiate : 'Je dois partir maintenant.'",
                ImparfaitNotes = "L'imparfait indique une obligation ou un devoir répété dans le passé : 'Quand j'étais enfant, je devais ranger ma chambre tous les jours.'",
                FuturSimpleNotes = "Le futur simple exprime une obligation à venir : 'Tu devras finir ce travail demain.'",
                PasseComposeNotes = "Le passé composé indique qu'une obligation a été remplie ou accomplie : 'J'ai dû annuler le rendez-vous.'",
                ImperativeNotes = "L'impératif de 'devoir' est rare et utilisé dans des contextes très formels ou directives : 'Devez suivre les règles.'",
                ConditionnelPresentNotes = "Le conditionnel exprime une obligation hypothétique ou polie : 'Vous devriez consulter un médecin.'"
            }
        );
    }

    private static IrregularFrenchVerb CreateDire()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Dire,
            description: Constants.VerbDescriptions.Irregular.Dire,
            pastParticiple: "dit",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "dis",
                [Constants.Pronouns.Tu] = "dis",
                [Constants.Pronouns.IlElleOn] = "dit",
                [Constants.Pronouns.Nous] = "disons",
                [Constants.Pronouns.Vous] = "dites",
                [Constants.Pronouns.IlsElles] = "disent"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "dis",
                [Constants.Pronouns.Nous] = "disons",
                [Constants.Pronouns.Vous] = "dites"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "dis",
                [Constants.Tenses.FuturSimple] = "dir",
                [Constants.Tenses.ConditionnelPresent] = "dir"
            },
            isModal: false,
            supportsProgressive: true,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Le présent exprime l'action de dire maintenant ou régulièrement : 'Je dis la vérité.'",
                PasseComposeNotes = "Le passé composé indique que l'action de dire a été accomplie : 'J'ai dit ce que je pensais.'",
                FuturSimpleNotes = "Le futur exprime ce que l'on dira dans l'avenir : 'Tu diras ton opinion demain.'",
                ConditionnelPresentNotes = "Le conditionnel exprime ce qu'on dirait dans un contexte hypothétique ou poli : 'Il dirait la même chose si vous lui demandiez.'",
                ImperativeNotes = "L'impératif donne des instructions ou ordres concernant le fait de dire : 'Dis la vérité !', 'Dites ce que vous pensez !'"
            }
        );
    }

    #endregion
}