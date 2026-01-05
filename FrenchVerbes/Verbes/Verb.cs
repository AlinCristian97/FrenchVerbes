namespace FrenchVerbes.Verbes;

public abstract class Verb
{
    public string Infinitive { get; }

    public Verb(string infinitive)
    {
        Infinitive = infinitive.ToLowerInvariant();
    }

    public abstract void PrintSummary();
}