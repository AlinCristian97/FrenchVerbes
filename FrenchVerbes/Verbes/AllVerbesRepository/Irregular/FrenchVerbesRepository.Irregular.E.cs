using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularEVerbs()
    {
        _verbs.Add(CreateEtre());
    }

    #region FactoryMethods

    private static IrregularFrenchVerb CreateEtre()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Etre,
            description: Constants.VerbDescriptions.Irregular.Etre,
            pastParticiple: "été",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "suis",
                [Constants.Pronouns.Tu] = "es",
                [Constants.Pronouns.IlElleOn] = "est",
                [Constants.Pronouns.Nous] = "sommes",
                [Constants.Pronouns.Vous] = "êtes",
                [Constants.Pronouns.IlsElles] = "sont"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "sois",
                [Constants.Pronouns.Nous] = "soyons",
                [Constants.Pronouns.Vous] = "soyez"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "ét",
                [Constants.Tenses.FuturSimple] = "ser",
                [Constants.Tenses.ConditionnelPresent] = "ser"
            },
            supportsProgressive: false,
            tensesNotes: new NotesObject
            {
                ImperativeNotes = "C'est grammaticalement correct, mais son usage est très rare dans la langue parlée.",
                PasseRecentNotes = "Grammaticalement correct, mais cela exprime un état et non une action ponctuelle."
            }
        );
    }

    #endregion
}