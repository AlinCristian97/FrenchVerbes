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
        _verbs.Add(CreateSavoir());
        
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
            supportsProgressive: false,
            tensesNotes: new NotesObject
            {
                ImperativeNotes = "'Vouloir' a une forme impérative rare et archaïque. Elle n’est utilisée que dans des expressions figées ou dans un registre littéraire ancien, notamment pour exprimer un ordre solennel ou une injonction formelle, par exemple : 'Veuillez patienter', 'Veuillez agréer…'. En français moderne courant, on évite l’impératif de vouloir et on lui préfère des tournures plus naturelles."
            }
        );
    }
    
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
                ImperativeNotes = "L'impératif est utilisé pour donner des instructions ou conseils concernant la connaissance : 'Sache la vérité !', 'Sachez respecter les règles !'"
            }
        );
    }

    #endregion
    
    #endregion
}
