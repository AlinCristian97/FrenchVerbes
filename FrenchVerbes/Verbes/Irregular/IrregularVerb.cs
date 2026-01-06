namespace FrenchVerbes.Verbes;

public class IrregularFrenchVerb : Verb
{
    private readonly Dictionary<string, string> _presentTense;

    public IrregularFrenchVerb(
        string infinitive,
        Dictionary<string, string> presentTense)
        : base(infinitive)
    {
        _presentTense = presentTense;
    }

    public override void PrintSummary()
    {
        Console.WriteLine($"Verb: {Infinitive}");
        Console.WriteLine("Type: Irregular");
        Console.WriteLine("Present tense:");

        foreach (var (pronoun, form) in _presentTense)
        {
            Console.WriteLine($"{pronoun} {form}");
        }
    }
}
