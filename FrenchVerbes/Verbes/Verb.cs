using FrenchVerbes.Extensions;

namespace FrenchVerbes.Verbes;

public abstract class Verb
{
    public string Infinitive { get; }
    public virtual bool UsesEtre => false;
    
    protected static readonly string[] ImparfaitEndings = { "ais", "ais", "ait", "ions", "iez", "aient" };
    protected static readonly string[] FuturSimpleEndings = { "ai", "as", "a", "ons", "ez", "ont" };
    protected virtual string[] ConditionnelPresentEndings => ImparfaitEndings;
    protected abstract string PastParticiple { get; }

    public Verb(string infinitive)
    {
        Infinitive = infinitive.ToLowerInvariant();
    }

    protected abstract string GetStemForTense(string tense);
    
    public virtual void PrintSummary()
    {
        PrintGeneralInfo();
        Console.WriteLine();
        PrintPresent();
        Console.WriteLine();
        PrintImparfait();
        Console.WriteLine();
        PrintFuturSimple();
        Console.WriteLine();
        PrintPasseCompose();
        Console.WriteLine();
        PrintFuturProche();
        Console.WriteLine();
        PrintPasseRecent();
        Console.WriteLine();
        PrintImperative();
        Console.WriteLine();
        PrintConditionnelPresent();
    }
    
    private void PrintGeneralInfo()
    {
        Console.Write("Verb: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Infinitive);
        Console.ResetColor();
    }
    
    protected abstract void PrintPresent();
    protected abstract void PrintImperative();

    protected virtual void PrintImparfait()
    {
        Console.WriteLine(Constants.Tenses.Imparfait.ToHeadline());
        string stem = GetStemForTense(Constants.Tenses.Imparfait);
        PrintTense(stem, ImparfaitEndings);
    }
    
    private void PrintFuturSimple()
    {
        Console.WriteLine(Constants.Tenses.FuturSimple.ToHeadline());
        string stem = GetStemForTense(Constants.Tenses.FuturSimple);
        PrintTense(stem, FuturSimpleEndings);
    }
    
    private void PrintConditionnelPresent()
    {
        Console.WriteLine(Constants.Tenses.ConditionnelPresent.ToHeadline());
        string stem = GetStemForTense(Constants.Tenses.ConditionnelPresent);
        PrintTense(stem, ConditionnelPresentEndings);
    }
    
    private void PrintPasseCompose()
    {
        Console.WriteLine(Constants.Tenses.PasseCompose.ToHeadline());
        string[] aux = UsesEtre 
            ? Constants.Tenses.Auxiliaries.PasseCompose_AuxiliaryEtre 
            : Constants.Tenses.Auxiliaries.PasseCompose_AuxiliaryAvoir;

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string pronoun = Constants.Pronouns.All[i].ContractJe(aux[i]);
            string space = pronoun.EndsWith("'") ? "" : " ";
            
            Console.Write($"{pronoun}{space}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{aux[i]} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(PastParticiple);
            Console.ResetColor();
        }
    }
    
    private void PrintFuturProche()
    {
        Console.WriteLine(Constants.Tenses.FuturProche.ToHeadline());
        string[] aux = Constants.Tenses.Auxiliaries.FuturProche_Auxiliary;

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{aux[i]} ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Infinitive);
            Console.ResetColor();
        }
    }

    private void PrintPasseRecent()
    {
        Console.WriteLine(Constants.Tenses.PasseRecent.ToHeadline());
        string[] aux = Constants.Tenses.Auxiliaries.PasseRecent_Auxiliary;

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{aux[i]} ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("de ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Infinitive);
            Console.ResetColor();
        }
    }
    
    // Helper to avoid repeating the for-loop everywhere
    private void PrintTense(string stem, string[] endings)
    {
        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");
            Console.Write(stem);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(endings[i]);
            Console.ResetColor();
        }
    }
}