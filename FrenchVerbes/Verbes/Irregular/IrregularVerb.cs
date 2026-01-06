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

    protected override string PastParticiple { get; }

    protected override string GetStemForTense(string tense)
    {
        throw new NotImplementedException();
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

    protected override void PrintPresent()
    {
        throw new NotImplementedException();
    }

    protected override void PrintImperative()
    {
        throw new NotImplementedException();
    }
}
