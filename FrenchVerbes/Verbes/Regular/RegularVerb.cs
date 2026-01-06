using FrenchVerbes.Extensions;

namespace FrenchVerbes.Verbes;

public abstract class RegularVerb : Verb
{
    protected RegularVerb(string infinitive)
        : base(infinitive)
    {
    }
    
    protected abstract string Ending { get; }

    protected abstract string[] PresentTenseEndings { get; }
    protected abstract string[] ImperativeEndings { get; }
    protected override string PastParticiple => Infinitive[..^Ending.Length] + PastParticipleSuffix;

    protected abstract string PastParticipleSuffix { get; }

    protected override string GetStemForTense(string tense) => tense switch
    {
        Constants.Tenses.Present => Infinitive[..^Ending.Length],
        Constants.Tenses.Imparfait => Infinitive[..^Ending.Length],
        Constants.Tenses.FuturSimple => Infinitive,
        Constants.Tenses.ConditionnelPresent => Infinitive,
        _ => throw new Exception("Tense not found.")
    };

    // todo: override to add type ending?
    private void PrintGeneralInfo()
    {
        Console.WriteLine($"Type: Regular ('{Ending}'-verb)");
    }
    
    protected override void PrintImperative()
    {
        Console.WriteLine(Constants.Tenses.Imperative.ToHeadline());
        string[] pronouns = { Constants.Pronouns.Tu, Constants.Pronouns.Nous, Constants.Pronouns.Vous };
        for (int i = 0; i < pronouns.Length; i++)
        {
            Console.Write($"{pronouns[i]} {Infinitive[..^Ending.Length]}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ImperativeEndings[i]);

            Console.ResetColor();
        }
    }

    protected override void PrintPresent()
    {
        Console.WriteLine(Constants.Tenses.Present.ToHeadline());
        string stem = GetStemForTense(Constants.Tenses.Present);
        
        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");
            Console.Write(stem);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(PresentTenseEndings[i]);
            Console.ResetColor();
        }
    }
}