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

    protected override void PrintGeneralInfo()
    {
        base.PrintGeneralInfo();
        Console.WriteLine($"Type: Regular ('{Ending}'-verb)");
    }
    
    protected override void PrintImperative()
    {
        Console.WriteLine(Constants.Tenses.Imperative.ToHeadline());
        string stem = GetStemForTense(Constants.Tenses.Present);

        for (int i = 0; i < ImperativeEndings.Length; i++)
        {
            // No pronouns in Imperative!
            Console.Write(stem);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ImperativeEndings[i]);
            Console.ResetColor();
            
            Console.WriteLine(" !");
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