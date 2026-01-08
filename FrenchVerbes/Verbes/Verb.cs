using FrenchVerbes.Extensions;

namespace FrenchVerbes.Verbes;

public abstract class Verb
{
    public string Infinitive { get; }
    public string Description { get; }
    protected abstract string VerbType { get; }
    public virtual bool UsesEtre => false;
    public virtual bool IsModal { get; } = false;
    public virtual bool SupportsProgressive { get; } = true;
    
    protected static readonly string[] ImparfaitEndings = { "ais", "ais", "ait", "ions", "iez", "aient" };
    protected static readonly string[] FuturSimpleEndings = { "ai", "as", "a", "ons", "ez", "ont" };
    protected virtual string[] ConditionnelPresentEndings => ImparfaitEndings;
    protected abstract string PastParticiple { get; }

    private NotesObject? TensesNotes { get; } = null;

    public Verb(string infinitive, string description, NotesObject? tensesNotes = null)
    {
        Infinitive = infinitive.ToLowerInvariant();
        Description = description;
        TensesNotes = tensesNotes;
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
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(UsesEtre ? Constants.Verbs.Irregular.Etre : Constants.Verbs.Irregular.Avoir);
        Console.ResetColor();
        
        Console.Write("Past Participle: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(PastParticiple);
        Console.ResetColor(); 

        if (!SupportsProgressive)
        {
            Console.Write("Progressive: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Ce verbe n'utilise pas la forme progressive.");
            Console.ResetColor();
        }
        else
        {
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
        }
        
        Console.Write("Description: ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(Description);
        Console.ResetColor();
        PrintUtils.PrintSectionDivider();
    }

    protected void PrintNotesForTenseIfAny(string tense)
    {
        if (TensesNotes == null)
            return;
        
        string? notes = TensesNotes.GetNotesForTense(tense);

        if (string.IsNullOrWhiteSpace(notes))
            return;

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"{Constants.FrenchSymbols.LeGuillementOuvrant}{notes}{Constants.FrenchSymbols.LeGuillementFermant}");
        Console.ResetColor();
    }

    protected virtual void PrintPresent()
    {
        string tense = Constants.Tenses.Present;
        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
    }

    protected virtual void PrintImperative()
    {
        string tense = Constants.Tenses.Imperative;

        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
    }

    protected virtual void PrintImparfait()
    {
        string tense = Constants.Tenses.Imparfait;

        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
        string stem = GetStemForTense(tense);
        PrintTense(stem, ImparfaitEndings);
    }
    
    protected virtual void PrintFuturSimple()
    {
        string tense = Constants.Tenses.FuturSimple;

        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
        string stem = GetStemForTense(tense);
        PrintTense(stem, FuturSimpleEndings);
    }
    
    protected virtual void PrintConditionnelPresent()
    {
        string tense = Constants.Tenses.ConditionnelPresent;

        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
        string stem = GetStemForTense(tense);
        PrintTense(stem, ConditionnelPresentEndings);
    }
    
    private void PrintPasseCompose()
    {
        string tense = Constants.Tenses.PasseCompose;
        
        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
        string[] aux = UsesEtre 
            ? Constants.Tenses.Auxiliaries.PasseCompose_AuxiliaryEtre 
            : Constants.Tenses.Auxiliaries.PasseCompose_AuxiliaryAvoir;

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            PrintUtils.PrintPronoun(i, aux[i]);
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
        string tense = Constants.Tenses.FuturProche;
        
        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
        
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
        string tense = Constants.Tenses.PasseRecent;
        
        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);
        
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
            string fullForm = stem + endings[i];

            PrintUtils.PrintPronoun(i, fullForm);
            Console.Write(stem);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(endings[i]);
            Console.ResetColor();
        }
    }
}