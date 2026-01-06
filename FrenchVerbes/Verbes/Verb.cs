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
    
    public void PrintSummary()
    {
        PrintGeneralInfo();
        Console.WriteLine();
        PrintTenseWithExamples(Constants.Tenses.Present, PrintPresent);
        Console.WriteLine();
        PrintTenseWithExamples(Constants.Tenses.Imparfait, PrintImparfait);
        Console.WriteLine();
        PrintTenseWithExamples(Constants.Tenses.FuturSimple, PrintFuturSimple);
        Console.WriteLine();
        PrintTenseWithExamples(Constants.Tenses.PasseCompose, PrintPasseCompose);
        Console.WriteLine();
        PrintTenseWithExamples(Constants.Tenses.FuturProche, PrintFuturProche);
        Console.WriteLine();
        PrintTenseWithExamples(Constants.Tenses.PasseRecent, PrintPasseRecent);
        Console.WriteLine();
        PrintTenseWithExamples(Constants.Tenses.Imperative, PrintImperative);
        Console.WriteLine();
        PrintTenseWithExamples(Constants.Tenses.ConditionnelPresent, PrintConditionnelPresent);
    }
    
    private void PrintTenseWithExamples(string tenseName, Action printAction)
    {
        printAction();

        int count = 3;
        
        var examples = ExampleSentencesRepository.GetRandomSentences(Infinitive, tenseName, count);
        if (examples.Any())
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Exemples :");
            foreach (var example in examples)
            {
                Console.WriteLine($"  • {example}");
            }
            Console.ResetColor();
        }
    }
    
    protected virtual void PrintGeneralInfo()
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
            Console.Write(PastParticiple);

            // Handle agreement if auxiliary is 'être'
            if (UsesEtre)
            {
                // Index 0, 1, 2 are singular (Je, Tu, Il/Elle/On)
                // Index 3, 5 are always plural (Nous, Ils/Elles)
                // Index 4 (Vous) can be singular or plural, but usually shown as plural in charts
                
                if (i == 0 || i == 1) Console.Write("(e)");
                else if (i == 2) Console.Write(Constants.Pronouns.All[i].Contains("Elle") ? "e" : "(e)");
                else if (i == 3 || i == 4) Console.Write("(e)s");
                else if (i == 5) Console.Write(Constants.Pronouns.All[i].Contains("Elles") ? "es" : "s");
            }

            Console.WriteLine();
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
        string connector = "de";

        // Contract 'de' to 'd'' if the infinitive starts with a vowel
        if (Constants.Vowels.Contains(Infinitive[0]))
        {
            connector = "d'";
        }

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            Console.Write($"{Constants.Pronouns.All[i]} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{aux[i]} ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            
            // If it's d', don't add a space
            Console.Write(connector + (connector.EndsWith("'") ? "" : " "));
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Infinitive);
            Console.ResetColor();
        }
    }
    
    private void PrintTense(string stem, string[] endings)
    {
        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string pronoun = Constants.Pronouns.All[i];
            string fullForm = stem + endings[i];

            // Handle Je -> J' contraction
            if (i == 0 && Constants.Vowels.Contains(fullForm[0]))
            {
                pronoun = Constants.Pronouns.Je_Contracted;
            }

            string space = pronoun.EndsWith("'") ? "" : " ";
            Console.Write($"{pronoun}{space}");
            
            Console.Write(stem);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(endings[i]);
            Console.ResetColor();
        }
    }
}