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
    





    

    


    private static RegularErVerb CreateHabiter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Habiter,
            Constants.VerbDescriptions.Regular.Er.Habiter);
    }





    #endregion

    #region Ending in IR








    






    
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
