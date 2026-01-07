using FrenchVerbes.Verbes.Irregular;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static class VerbRepository
{
    private static readonly List<Verb> _verbs = new();
    
    static VerbRepository()
    {
        AddIrregularVerbs();
        AddRegularErVerbs();
        AddRegularIrVerbs();
        AddRegularReVerbs();
    }

    public static IReadOnlyList<Verb> Verbs => _verbs;

    public static Verb? GetByInfinitive(string input)
    {
        var normalized = input.Trim().ToLowerInvariant();

        return _verbs.FirstOrDefault(v => v.Infinitive == normalized);
    }

    public static Verb GetRandom()
    {
        var random = new Random();
        return _verbs[random.Next(_verbs.Count)];
    }

    #region Private Methods
    
    private static void AddIrregularVerbs()
    {
        _verbs.Add(CreateEtre());
        _verbs.Add(CreateAvoir());
        _verbs.Add(CreateAller());
        _verbs.Add(CreateFaire());
        _verbs.Add(CreatePouvoir());
        _verbs.Add(CreateVouloir());
    }

    private static void AddRegularErVerbs()
    {
        _verbs.Add(new RegularErVerb(Constants.Verbs.Regular.Er.Manger, Constants.VerbDescriptions.Regular.Er.Manger));
    }

    private static void AddRegularIrVerbs()
    {
        _verbs.Add(new RegularIrVerb(Constants.Verbs.Regular.Ir.Finir, Constants.VerbDescriptions.Regular.Ir.Finir));
    }

    private static void AddRegularReVerbs()
    {
        _verbs.Add(new RegularReVerb(Constants.Verbs.Regular.Re.Vendre, Constants.VerbDescriptions.Regular.Re.Vendre));
    }

    #region Irregular Verbs Factory Methods

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
            supportsProgressive: false
        );
    }

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
            supportsProgressive: false
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
            supportsProgressive: false
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
            supportsProgressive: false
        );
    }

    #endregion
    
    #endregion
}
