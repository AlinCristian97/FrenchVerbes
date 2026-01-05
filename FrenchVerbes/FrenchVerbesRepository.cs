using FrenchVerbes.Verbes;

namespace FrenchVerbes;

public static class VerbRepository
{
    private static readonly List<Verb> _verbs =
    [
        new IrregularFrenchVerb(
            Constants.Verbs.Etre,
            new Dictionary<string, string>
            {
                [Constants.Pronouns.Je] = "suis",
                [Constants.Pronouns.Tu] = "es",
                [Constants.Pronouns.IlElleOn] = "est",
                [Constants.Pronouns.Nous] = "sommes",
                [Constants.Pronouns.Vous] = "êtes",
                [Constants.Pronouns.IlsElles] = "sont"
            }),

        new IrregularFrenchVerb(
            Constants.Verbs.Avoir,
            new Dictionary<string, string>
            {
                [Constants.Pronouns.Je] = "ai",
                [Constants.Pronouns.Tu] = "as",
                [Constants.Pronouns.IlElleOn] = "a",
                [Constants.Pronouns.Nous] = "avons",
                [Constants.Pronouns.Vous] = "avez",
                [Constants.Pronouns.IlsElles] = "ont"
            }),

        new RegularErVerb(Constants.Verbs.Manger),
        new RegularIrVerb(Constants.Verbs.Finir),
        new RegularReVerb(Constants.Verbs.Vendre)
    ];

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
}
