
namespace FrenchVerbes.Verbes.Irregular;

public class IrregularFrenchVerb : Verb
{
    protected override string VerbType => "irregular  d-_-b";
    
    private readonly Dictionary<string, string> _presentTense;
    private readonly Dictionary<string, string>? _imperative;
    private readonly Dictionary<string, string> _stems;

    protected override string PastParticiple { get; }
    public override bool UsesEtre { get; }
    public override bool IsModal { get; }
    public override bool SupportsProgressive { get; }

    public IrregularFrenchVerb(
        string infinitive,
        string description,
        string pastParticiple,
        Dictionary<string, string> presentTense,
        Dictionary<string, string>? imperative,
        Dictionary<string, string> stems,
        bool usesEtre = false,
        bool isModal = false,
        bool supportsProgressive = true,
        NotesObject? tensesNotes = null)
        : base(infinitive, description, tensesNotes)
    {
        PastParticiple = pastParticiple;
        _presentTense = presentTense;
        _imperative = imperative;
        _stems = stems;
        UsesEtre = usesEtre;
        IsModal = isModal;
        SupportsProgressive = supportsProgressive;
    }

    protected override string GetStemForTense(string tense)
    {
        if (_stems.TryGetValue(tense, out var stem))
        {
            return stem;
        }

        throw new KeyNotFoundException($"Stem for tense '{tense}' was not provided for irregular verb '{Infinitive}'. " +
                                       $"Please ensure the stems dictionary includes all required tenses.");
    }

    protected override void PrintPresent()
    {
        base.PrintPresent();
        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string pronounLabel = Constants.Pronouns.All[i];
            if (_presentTense.TryGetValue(pronounLabel, out var form))
            {
                string displayPronoun = pronounLabel;

                // Handle Je -> J' contraction for irregular forms
                if (i == 0 && Constants.Vowels.Contains(form[0]))
                {
                    displayPronoun = Constants.Pronouns.Je_Contracted;
                }

                string space = displayPronoun.EndsWith("'") ? "" : " ";
                Console.WriteLine($"{displayPronoun}{space}{form}");
            }
        }
    }

    protected override void PrintImperative()
    {
        base.PrintImperative();
        
        if (_imperative == null)
        {
            Console.WriteLine("Ce verbe n'a pas de forme impérative. On utilise plutôt le subjonctif ou d'autres verbes.");
            return;
        }
        
        string[] labels = { Constants.Pronouns.Tu, Constants.Pronouns.Nous, Constants.Pronouns.Vous };

        foreach (var label in labels)
        {
            if (_imperative.TryGetValue(label, out var form))
            {
                // Imperative doesn't use pronouns, so we just print the form!
                Console.WriteLine($"{form} !");
            }
        }
    }
}