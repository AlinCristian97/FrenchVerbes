namespace FrenchVerbes.Verbes;

public abstract class RegularVerb : Verb
{
    protected RegularVerb(string infinitive)
        : base(infinitive)
    {
    }

    public virtual bool UsesEtre => false;
    
    protected abstract string Ending { get; }

    protected abstract string[] PresentTenseEndings { get; }

    public override void PrintSummary()
    {
        Console.WriteLine($"Verb: {Infinitive}");
        Console.WriteLine("Type: Regular");
        Console.WriteLine($"Group: {Ending}");
        Console.WriteLine("Present tense:");

        var stem = Infinitive[..^Ending.Length];

        for (int i = 0; i < PresentTenseEndings.Length; i++)
        {
            Console.WriteLine($"{GetPronoun(i)} {stem}{PresentTenseEndings[i]}");
        }
    }

    protected static string GetPronoun(int index) => index switch
    {
        0 => Constants.Pronouns.Je,
        1 => Constants.Pronouns.Tu,
        2 => Constants.Pronouns.IlElleOn,
        3 => Constants.Pronouns.Nous,
        4 => Constants.Pronouns.Vous,
        5 => Constants.Pronouns.IlsElles,
        _ => throw new ArgumentOutOfRangeException()
    };
}