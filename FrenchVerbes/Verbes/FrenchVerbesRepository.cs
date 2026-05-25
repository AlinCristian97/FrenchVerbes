using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Irregular;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
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
        AddIrregularAVerbs();
        AddIrregularBVerbs();
        AddIrregularCVerbs();
        AddIrregularDVerbs();
        AddIrregularEVerbs();
        AddIrregularFVerbs();
        AddIrregularGVerbs();
        AddIrregularHVerbs();
        AddIrregularIVerbs();
        AddIrregularJVerbs();
        AddIrregularKVerbs();
        AddIrregularLVerbs();
        AddIrregularMVerbs();
        AddIrregularNVerbs();
        AddIrregularOVerbs();
        AddIrregularPVerbs();
        AddIrregularQVerbs();
        AddIrregularRVerbs();
        AddIrregularSVerbs();
        AddIrregularTVerbs();
        AddIrregularUVerbs();
        AddIrregularVVerbs();
        AddIrregularWVerbs();
        AddIrregularXVerbs();
        AddIrregularYVerbs();
        AddIrregularZVerbs();
    }

    private static void AddRegularErVerbs()
    {
        AddRegularErAVerbs();
        AddRegularErBVerbs();
        AddRegularErCVerbs();
        AddRegularErDVerbs();
        AddRegularErEVerbs();
        AddRegularErFVerbs();
        AddRegularErGVerbs();
        AddRegularErHVerbs();
        AddRegularErIVerbs();
        AddRegularErJVerbs();
        AddRegularErKVerbs();
        AddRegularErLVerbs();
        AddRegularErMVerbs();
        AddRegularErNVerbs();
        AddRegularErOVerbs();
        AddRegularErPVerbs();
        AddRegularErQVerbs();
        AddRegularErRVerbs();
        AddRegularErSVerbs();
        AddRegularErTVerbs();
        AddRegularErUVerbs();
        AddRegularErVVerbs();
        AddRegularErWVerbs();
        AddRegularErXVerbs();
        AddRegularErYVerbs();
        AddRegularErZVerbs();
    }

    private static void AddRegularIrVerbs()
    {
        AddRegularIrAVerbs();
        AddRegularIrBVerbs();
        AddRegularIrCVerbs();
        AddRegularIrDVerbs();
        AddRegularIrEVerbs();
        AddRegularIrFVerbs();
        AddRegularIrGVerbs();
        AddRegularIrHVerbs();
        AddRegularIrIVerbs();
        AddRegularIrJVerbs();
        AddRegularIrKVerbs();
        AddRegularIrLVerbs();
        AddRegularIrMVerbs();
        AddRegularIrNVerbs();
        AddRegularIrOVerbs();
        AddRegularIrPVerbs();
        AddRegularIrQVerbs();
        AddRegularIrRVerbs();
        AddRegularIrSVerbs();
        AddRegularIrTVerbs();
        AddRegularIrUVerbs();
        AddRegularIrVVerbs();
        AddRegularIrWVerbs();
        AddRegularIrXVerbs();
        AddRegularIrYVerbs();
        AddRegularIrZVerbs();
    }

    private static void AddRegularReVerbs()
    {
        AddRegularReAVerbs();
        AddRegularReBVerbs();
        AddRegularReCVerbs();
        AddRegularReDVerbs();
        AddRegularReEVerbs();
        AddRegularReFVerbs();
        AddRegularReGVerbs();
        AddRegularReHVerbs();
        AddRegularReIVerbs();
        AddRegularReJVerbs();
        AddRegularReKVerbs();
        AddRegularReLVerbs();
        AddRegularReMVerbs();
        AddRegularReNVerbs();
        AddRegularReOVerbs();
        AddRegularRePVerbs();
        AddRegularReQVerbs();
        AddRegularReRVerbs();
        AddRegularReSVerbs();
        AddRegularReTVerbs();
        AddRegularReUVerbs();
        AddRegularReVVerbs();
        AddRegularReWVerbs();
        AddRegularReXVerbs();
        AddRegularReYVerbs();
        AddRegularReZVerbs();
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
    
    private static RegularErVerb CreateAdapter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Adapter,
            Constants.VerbDescriptions.Regular.Er.Adapter);
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

    private static RegularErVerb CreateHabiter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Habiter,
            Constants.VerbDescriptions.Regular.Er.Habiter);
    }

    private static RegularErVerb CreateChanger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Changer,
            Constants.VerbDescriptions.Regular.Er.Changer);
    }

    private static RegularErVerb CreateCommencer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Commencer,
            Constants.VerbDescriptions.Regular.Er.Commencer,
            tensesNotes: new NotesObject
            {
                PresentNotes =
                    "Au présent, le verbe change le 'c' en 'ç' devant 'a' ou 'o' pour conserver le son doux : nous commençons.",
                ImparfaitNotes =
                    "À l’imparfait, le verbe suit la même règle pour la première personne du pluriel : nous commencions."
            });
    }

    #endregion

    #region Ending in IR

    private static RegularIrVerb CreateNourrir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Nourrir,
            Constants.VerbDescriptions.Regular.Ir.Nourrir
        );
    }

    private static RegularIrVerb CreateGrandir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Grandir,
            Constants.VerbDescriptions.Regular.Ir.Grandir);
    }

    private static RegularIrVerb CreateFinir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Finir,
            Constants.VerbDescriptions.Regular.Ir.Finir);
    }

    private static RegularIrVerb CreateAccomplir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Accomplir,
            Constants.VerbDescriptions.Regular.Ir.Accomplir);
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

    private static RegularReVerb CreateDefendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Defendre,
            Constants.VerbDescriptions.Regular.Re.Defendre
        );
    }
    
    private static RegularReVerb CreateRendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Rendre,
            Constants.VerbDescriptions.Regular.Re.Rendre);
    }
    
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
    
    private static RegularReVerb CreateDescendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Descendre,
            Constants.VerbDescriptions.Regular.Re.Descendre,
            usesEtre: true,
            tensesNotes: new NotesObject
            {
                PasseComposeNotes = "Descendre se conjugue généralement avec l'auxiliaire 'être' au passé composé pour exprimer un mouvement : je suis descendu(e). Si le verbe a un complément direct, on utilise 'avoir' : j'ai descendu les escaliers.",
                PresentNotes = "Descendre est régulier au présent : je descends, tu descends, il descend, nous descendons, vous descendez, ils descendent."
            });
    }
    
    #endregion
    
    #endregion
    
    #endregion
}
