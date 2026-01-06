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
    protected abstract string[] ImparfaitEndings { get; }
    protected abstract string[] FuturSimpleEndings { get; }
    protected abstract string[] ConditionnelPresentEndings { get; }
    protected abstract string[] ImperativeEndings { get; }
    protected virtual string PastParticiple => Infinitive[..^Ending.Length] + PastParticipleSuffix;

    protected abstract string PastParticipleSuffix { get; }

    protected virtual string GetStemForTense(string tense) => tense switch
    {
        Constants.Tenses.Present => Infinitive[..^Ending.Length],
        Constants.Tenses.Imparfait => Infinitive[..^Ending.Length],
        Constants.Tenses.FuturSimple => Infinitive,
        Constants.Tenses.ConditionnelPresent => Infinitive,
        _ => throw new Exception("Tense not found.")
    };

    public override void PrintSummary()
    {
        PrintGeneralInfo();
        Console.WriteLine();

        PrintPresent();
        Console.WriteLine();
        
        PrintImparfait();
        Console.WriteLine();
        
        PrintFuturSimple();
        Console.WriteLine();
        
        PrintConditionnelPresent();
        Console.WriteLine();
        
        PrintPasseCompose();
        Console.WriteLine();
        
        PrintFuturProche();
        Console.WriteLine();
        
        PrintImperative();
        Console.WriteLine();
        
        PrintPasseRecent();
    }

    private void PrintGeneralInfo()
    {
        Console.Write("Verb: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Infinitive);
        Console.ResetColor();

        Console.WriteLine($"Type: Regular ('{Ending}'-verb)");
    }
    
    protected virtual void PrintPresent()
    {
        Console.WriteLine(Constants.Tenses.Present.ToHeadline());
        string stem = GetStemForTense(Constants.Tenses.Present);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");

            if (stem == Infinitive) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(stem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(PresentTenseEndings[i]);
            Console.ResetColor();
        }
    }

    protected virtual void PrintImparfait()
    {
        Console.WriteLine(Constants.Tenses.Imparfait.ToHeadline());
        string stem = GetStemForTense(Constants.Tenses.Imparfait);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");

            if (stem == Infinitive) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(stem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ImparfaitEndings[i]);
            Console.ResetColor();
        }
    }

    protected void PrintFuturSimple()
    {
        Console.WriteLine(Constants.Tenses.FuturSimple.ToHeadline());
        string stem = GetStemForTense(Constants.Tenses.FuturSimple);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");

            if (stem == Infinitive) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(stem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FuturSimpleEndings[i]);
            Console.ResetColor();
        }
    }

    protected void PrintConditionnelPresent()
    {
        Console.WriteLine(Constants.Tenses.ConditionnelPresent.ToHeadline());
        string stem = GetStemForTense(Constants.Tenses.ConditionnelPresent);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");

            if (stem == Infinitive) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(stem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ConditionnelPresentEndings[i]);
            Console.ResetColor();
        }
    }

    private void PrintPasseCompose()
    {
        Console.WriteLine(Constants.Tenses.PasseCompose.ToHeadline());

        string participle = PastParticiple;
        string[] aux = UsesEtre
            ? Constants.Tenses.Auxiliaries.PasseCompose_AuxiliaryEtre
            : Constants.Tenses.Auxiliaries.PasseCompose_AuxiliaryAvoir;

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string pronoun = Constants.Pronouns.All[i];
            bool addSpace = true;

            // Only contract "Je" before a vowel auxiliary
            if (i == 0) // first pronoun is "Je"
            {
                pronoun = pronoun.ContractJe(aux[i]);
                if (pronoun == Constants.Pronouns.Je_Contracted)
                    addSpace = false; // don't add extra space after J'
            }

            Console.Write(pronoun);
            if (addSpace)
            {
                Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(aux[i] + " ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(participle);

            Console.ResetColor();
        }
    }

    private void PrintFuturProche()
    {
        Console.WriteLine(Constants.Tenses.FuturProche.ToHeadline());
        string infinitive = Infinitive;
        string[] aux = Constants.Tenses.Auxiliaries.FuturProche_Auxiliary;

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(aux[i] + " ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(infinitive);

            Console.ResetColor();
        }
    }

    private void PrintImperative()
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
    
    private void PrintPasseRecent()
    {
        Console.WriteLine(Constants.Tenses.PasseRecent.ToHeadline());
        string infinitive = Infinitive;
        string[] aux = Constants.Tenses.Auxiliaries.PasseRecent_Auxiliary;

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(aux[i] + " ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("de ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(infinitive);
            Console.ResetColor();
        }
    }
}