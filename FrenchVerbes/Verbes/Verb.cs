using FrenchVerbes.Extensions;

namespace FrenchVerbes.Verbes;

public abstract class Verb
{
    public string Infinitive { get; }
    public string Description { get; }
    protected abstract string VerbType { get; }
    public virtual bool UsesEtre => false;
    
    protected static readonly string[] ImparfaitEndings = { "ais", "ais", "ait", "ions", "iez", "aient" };
    protected static readonly string[] FuturSimpleEndings = { "ai", "as", "a", "ons", "ez", "ont" };
    protected virtual string[] ConditionnelPresentEndings => ImparfaitEndings;
    protected abstract string PastParticiple { get; }

    public Verb(string infinitive, string description)
    {
        Infinitive = infinitive.ToLowerInvariant();
        Description = description;
    }

    protected abstract string GetStemForTense(string tense);
    
    public void PrintSummary()
    {
        PrintGeneralInfo();
        PrintTenseWithExamples(Constants.Tenses.Present, PrintPresent);
        PrintUtils.PrintSectionDivider();
        PrintTenseWithExamples(Constants.Tenses.Imparfait, PrintImparfait);
        PrintUtils.PrintSectionDivider();
        PrintTenseWithExamples(Constants.Tenses.FuturSimple, PrintFuturSimple);
        PrintUtils.PrintSectionDivider();
        PrintTenseWithExamples(Constants.Tenses.PasseCompose, PrintPasseCompose);
        PrintUtils.PrintSectionDivider();
        PrintTenseWithExamples(Constants.Tenses.FuturProche, PrintFuturProche);
        PrintUtils.PrintSectionDivider();
        PrintTenseWithExamples(Constants.Tenses.PasseRecent, PrintPasseRecent);
        PrintUtils.PrintSectionDivider();
        PrintTenseWithExamples(Constants.Tenses.Imperative, PrintImperative);
        PrintUtils.PrintSectionDivider();
        PrintTenseWithExamples(Constants.Tenses.ConditionnelPresent, PrintConditionnelPresent);
        PrintUtils.PrintSectionDivider();
    }
    
    private void PrintTenseWithExamples(string tenseName, Action printAction)
    {
        printAction();

        int count = 3;
        
        var examples = ExampleSentencesRepository.GetRandomSentences(Infinitive, tenseName, count);
        if (examples.Any())
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var example in examples)
            {
                Console.WriteLine(example);
            }
            Console.ResetColor();
        }
    }
    
    private void PrintGeneralInfo()
    {
        PrintUtils.PrintSectionDivider();
        Console.Write("Verb: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Infinitive);
        Console.ResetColor();

        Console.Write("Type: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(VerbType);
        Console.ResetColor();
        
        Console.Write("Auxiliary: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(UsesEtre ? Constants.Verbs.Irregular.Etre : Constants.Verbs.Irregular.Avoir);
        Console.ResetColor();
        
        Console.Write("Past Participle: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(PastParticiple);
        Console.ResetColor();
        
        Console.Write("Progressive: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        
        string connector = "de";
        if (Constants.Vowels.Contains(Infinitive[0]))
        {
            connector = "d'";
        }
        
        string space = connector.EndsWith("'") ? "" : " ";

        Console.WriteLine($"{Constants.Verbs.Irregular.Etre} en train {connector}{space}{Infinitive}");
        Console.ResetColor();
        
        Console.Write("Description: ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(Description);
        Console.ResetColor();
        PrintUtils.PrintSectionDivider();
    }
    
    protected abstract void PrintPresent();
    protected abstract void PrintImperative();

    protected virtual void PrintImparfait()
    {
        PrintUtils.PrintHeadline(Constants.Tenses.Imparfait);
        string stem = GetStemForTense(Constants.Tenses.Imparfait);
        PrintTense(stem, ImparfaitEndings);
    }
    
    private void PrintFuturSimple()
    {
        PrintUtils.PrintHeadline(Constants.Tenses.FuturSimple);
        string stem = GetStemForTense(Constants.Tenses.FuturSimple);
        PrintTense(stem, FuturSimpleEndings);
    }
    
    private void PrintConditionnelPresent()
    {
        PrintUtils.PrintHeadline(Constants.Tenses.ConditionnelPresent);
        string stem = GetStemForTense(Constants.Tenses.ConditionnelPresent);
        PrintTense(stem, ConditionnelPresentEndings);
    }
    
    private void PrintPasseCompose()
    {
        PrintUtils.PrintHeadline(Constants.Tenses.PasseCompose);
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
                // i = 0 (Je), 1 (Tu) -> optional (e)
                if (i == 0 || i == 1) 
                {
                    Console.Write("(e)");
                }
                // i = 2 (Il/Elle/On) -> Il/On is masc, Elle is fem
                else if (i == 2) 
                {
                    Console.Write("(e)"); // Shown as (e) because of the shared line Il/Elle/On
                }
                // i = 3 (Nous), 4 (Vous) -> always plural 's', optional feminine 'e'
                else if (i == 3 || i == 4) 
                {
                    Console.Write("(e)s");
                }
                // i = 5 (Ils/Elles) -> Ils is 's', Elles is 'es'
                else if (i == 5) 
                {
                    Console.Write(Constants.Pronouns.All[i].Contains("Elles") ? "es" : "s");
                }
            }

            Console.WriteLine();
            Console.ResetColor();
        }
    }
    
    private void PrintFuturProche()
    {
        PrintUtils.PrintHeadline(Constants.Tenses.FuturProche);
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
        PrintUtils.PrintHeadline(Constants.Tenses.PasseRecent);
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