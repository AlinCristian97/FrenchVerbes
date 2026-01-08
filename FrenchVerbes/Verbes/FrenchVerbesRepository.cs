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
    
    public static Verb GetRandomRegularByGroup(string group)
    {
        List<Verb> filtered = group switch
        {
            Constants.VerbTypes.RegularTypes.Er => _verbs.OfType<RegularErVerb>().Cast<Verb>().ToList(),
            Constants.VerbTypes.RegularTypes.Ir => _verbs.OfType<RegularIrVerb>().Cast<Verb>().ToList(),
            Constants.VerbTypes.RegularTypes.Re => _verbs.OfType<RegularReVerb>().Cast<Verb>().ToList(),
            _ => new List<Verb>()
        };

        if (!filtered.Any())
            throw new InvalidOperationException($"No verbs found for group {group}");

        var random = new Random();
        return filtered[random.Next(filtered.Count)];
    }

    public static Verb GetRandomRegular()
    {
        var filtered = _verbs.OfType<RegularVerb>().ToList();

        if (!filtered.Any())
            throw new InvalidOperationException("No regular verbs found");

        var random = new Random();
        return filtered[random.Next(filtered.Count)];
    }

    public static Verb GetRandomIrregular()
    {
        var filtered = _verbs.OfType<IrregularFrenchVerb>().ToList();

        if (!filtered.Any())
            throw new InvalidOperationException("No irregular verbs found");

        var random = new Random();
        return filtered[random.Next(filtered.Count)];
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
        _verbs.Add(CreateVenir());
        _verbs.Add(CreateVoir());
        _verbs.Add(CreateDire());
        _verbs.Add(CreatePrendre());
        _verbs.Add(CreateDevoir());
        
    }

    private static void AddRegularErVerbs()
    {
        _verbs.Add(CreateManger());
        _verbs.Add(CreateAcheter());
        _verbs.Add(CreateAimer());
        _verbs.Add(CreateAppeler());
        _verbs.Add(CreateArriver());
        
    }

    private static void AddRegularIrVerbs()
    {
        _verbs.Add(CreateFinir());
        _verbs.Add(CreateAgrandir());
        _verbs.Add(CreateApplaudir());
        _verbs.Add(CreateBatir());
        _verbs.Add(CreateChoisir());
        
    }

    private static void AddRegularReVerbs()
    {
        _verbs.Add(CreateVendre());
        _verbs.Add(CreateAttendre());
        _verbs.Add(CreateComprendre());
        _verbs.Add(CreateConfondre());
        
    }

    #region Regular Verbs Factory Methods

    #region Ending in ER

    private static RegularErVerb CreateManger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Manger,
            Constants.VerbDescriptions.Regular.Er.Manger,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Manger ajoute un 'e' devant la terminaison au présent avec 'nous' pour conserver le son doux du 'g' : nous mangeons."
            });
    }

    private static RegularErVerb CreateAcheter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Acheter,
            Constants.VerbDescriptions.Regular.Er.Acheter,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Acheter change de radical au présent pour certaines personnes : j'achète, tu achètes, il achète, mais nous achetons.",
                FuturSimpleNotes = "Au futur et au conditionnel, acheter utilise le radical 'achèter-' : j'achèterai, j'achèterais."
            });
    }

    private static RegularErVerb CreateAimer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Aimer,
            Constants.VerbDescriptions.Regular.Er.Aimer);
    }
    
    private static RegularErVerb CreateAppeler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Appeler,
            Constants.VerbDescriptions.Regular.Er.Appeler,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Au présent, le 'l' se double pour certaines personnes : j'appelle, tu appelles, il/elle appelle, mais nous appelons, vous appelez.",
                FuturSimpleNotes = "Au futur et au conditionnel, le radical prend également un 'l' doublé : j'appellerai, je appellerais."
            });
    }
    
    private static RegularErVerb CreateArriver()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Arriver,
            Constants.VerbDescriptions.Regular.Er.Arriver,
            usesEtre: true,
            tensesNotes: new NotesObject
            {
                PasseComposeNotes = "Arriver se conjugue avec l'auxiliaire 'être' au passé composé : je suis arrivé(e). Le participe passé s'accorde en genre et en nombre avec le sujet.",
                PresentNotes = "Arriver est régulier au présent : j'arrive, tu arrives, il/elle arrive, nous arrivons, vous arrivez, ils/elles arrivent."
            });
    }

    #endregion

    #region Ending in IR

    private static RegularIrVerb CreateFinir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Finir,
            Constants.VerbDescriptions.Regular.Ir.Finir);
    }

    private static RegularIrVerb CreateAgrandir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Agrandir,
            Constants.VerbDescriptions.Regular.Ir.Agrandir);
    }

    private static RegularIrVerb CreateApplaudir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Applaudir,
            Constants.VerbDescriptions.Regular.Ir.Applaudir);
    }
    
    private static RegularIrVerb CreateBatir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Batir,
            Constants.VerbDescriptions.Regular.Ir.Batir);
    }

    private static RegularIrVerb CreateChoisir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Choisir,
            Constants.VerbDescriptions.Regular.Ir.Choisir);
    }
    
    #endregion

    #region Ending in RE

    private static RegularReVerb CreateVendre()
    {
        return new RegularReVerb(Constants.Verbs.Regular.Re.Vendre, Constants.VerbDescriptions.Regular.Re.Vendre);
    }

    private static RegularReVerb CreateAttendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Attendre,
            Constants.VerbDescriptions.Regular.Re.Attendre);
    }

    private static RegularReVerb CreateComprendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Comprendre,
            Constants.VerbDescriptions.Regular.Re.Comprendre);
    }
    
    private static RegularReVerb CreateConfondre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Confondre,
            Constants.VerbDescriptions.Regular.Re.Confondre);
    }

    #endregion
    
    #endregion
    
    #region Irregular Verbs Factory Methods

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
            supportsProgressive: false,
            tensesNotes: new NotesObject
            {
                ImperativeNotes = "C'est grammaticalement correct, mais son usage est très rare dans la langue parlée.",
                PasseRecentNotes = "Grammaticalement correct, mais la capacité n’est pas une action ponctuelle."
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
                ImperativeNotes = "L'impératif est utilisé pour donner des instructions ou conseils concernant la connaissance : 'Sache la vérité !', 'Sachez respecter les règles !'. C'est grammaticalement correct, mais son usage est très rare dans la langue parlée.",
                PasseRecentNotes = "Grammaticalement correct, mais le savoir n’est pas instantané."
            }
        );
    }

    #endregion
    
    #endregion
}
