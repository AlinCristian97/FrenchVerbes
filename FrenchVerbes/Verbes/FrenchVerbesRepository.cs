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

    #endregion
}
