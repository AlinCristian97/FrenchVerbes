using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularFVerbs()
    {
        _verbs.Add(CreateFaire());
    }

    #region FactoryMethods

    private static IrregularFrenchVerb CreateFaire()
    {
        return new IrregularFrenchVerb(
            Constants.Verbs.Irregular.Faire,
            description: Constants.VerbDescriptions.Irregular.Faire,
            pastParticiple: "fait",
            presentTense: new()
            {
                [Constants.Pronouns.Je] = "fais",
                [Constants.Pronouns.Tu] = "fais",
                [Constants.Pronouns.IlElleOn] = "fait",
                [Constants.Pronouns.Nous] = "faisons",
                [Constants.Pronouns.Vous] = "faites",
                [Constants.Pronouns.IlsElles] = "font"
            },
            imperative: new()
            {
                [Constants.Pronouns.Tu] = "fais",
                [Constants.Pronouns.Nous] = "faisons",
                [Constants.Pronouns.Vous] = "faites"
            },
            stems: new()
            {
                [Constants.Tenses.Imparfait] = "fais",
                [Constants.Tenses.FuturSimple] = "fer",
                [Constants.Tenses.ConditionnelPresent] = "fer"
            }
        );
    }

    #endregion
}