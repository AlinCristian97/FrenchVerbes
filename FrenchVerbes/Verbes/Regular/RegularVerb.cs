using FrenchVerbes.Extensions;

namespace FrenchVerbes.Verbes.Regular;

public abstract class RegularVerb : Verb
{
    protected override string VerbType => Constants.VerbTypes.Regular;
    public override bool UsesEtre { get; }

    protected RegularVerb(string infinitive, string description, bool usesEtre = false, NotesObject? tensesNotes = null)
        : base(infinitive, description, tensesNotes)
    {
        UsesEtre = usesEtre;
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
    
    protected override void PrintImperative()
    {
        base.PrintImperative();
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
        base.PrintPresent();
        string stem = GetStemForTense(Constants.Tenses.Present);
        
        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            PrintUtils.PrintPronoun(i, stem);
            Console.Write(stem);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(PresentTenseEndings[i]);
            Console.ResetColor();
        }
    }
}