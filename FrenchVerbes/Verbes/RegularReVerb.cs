using FrenchVerbes.Extensions;

namespace FrenchVerbes.Verbes;

public class RegularReVerb : RegularVerb
{
    public RegularReVerb(string infinitive)
        : base(infinitive)
    {
    }

    protected override string Ending => "re";

    // Present tense
    protected override string[] PresentTenseEndings =>
        new[] { "s", "s", "", "ons", "ez", "ent" };
    
    // Imparfait (same for all regular verbs)
    protected virtual string[] ImparfaitEndings =>
        new[] { "ais", "ais", "ait", "ions", "iez", "aient" };

    // Futur Simple (same for all regular verbs)
    protected virtual string[] FuturSimpleEndings =>
        new[] { "rai", "ras", "ra", "rons", "rez", "ront" };

    // Conditionnel Présent (same as futur stem + imparfait endings)
    protected virtual string[] ConditionnelPresentEndings => ImparfaitEndings;

    // Imperative (only for 3 forms: Tu, Nous, Vous)
    protected virtual string[] ImperativeEndings =>
        new[] { PresentTenseEndings[1], PresentTenseEndings[3], PresentTenseEndings[4] };

    // Passé Composé (needs auxiliary verb + past participle)
    // We'll just use Avoir by default for regular -RE verbs
    protected virtual string PastParticiple => Infinitive[..^Ending.Length] + "u";
    
    public override void PrintSummary()
    {
        PrintGeneralInfo();
        Console.WriteLine();
        
        PrintTense(Constants.Tenses.Present, PresentTenseEndings, Infinitive[..^Ending.Length]);
        Console.WriteLine();
        
        PrintTense(Constants.Tenses.Imparfait, ImparfaitEndings, Infinitive[..^Ending.Length]);
        Console.WriteLine();
        
        PrintTense(Constants.Tenses.FuturSimple, FuturSimpleEndings, Infinitive);
        Console.WriteLine();
        
        PrintTense(Constants.Tenses.ConditionnelPresent, ConditionnelPresentEndings, Infinitive);
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
    
    private void PrintTense(string name, string[] endings, string stem)
    {
        Console.WriteLine($"{name.ToHeadline()}");
        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");

            if (stem == Infinitive)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write(stem);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(endings[i]);
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
            Console.Write($"{Constants.Pronouns.All[i]} ");

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
