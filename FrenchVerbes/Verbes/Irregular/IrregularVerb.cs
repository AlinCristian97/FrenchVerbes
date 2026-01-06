
using FrenchVerbes.Extensions;

namespace FrenchVerbes.Verbes.Irregular;

public class IrregularFrenchVerb : Verb
{
    private readonly Dictionary<string, string> _presentTense;
    private readonly Dictionary<string, string> _imperative;
    private readonly Dictionary<string, string> _stems;

    protected override string PastParticiple { get; }
    public override bool UsesEtre { get; }

    public IrregularFrenchVerb(
        string infinitive,
        string pastParticiple,
        Dictionary<string, string> presentTense,
        Dictionary<string, string> imperative,
        Dictionary<string, string> stems,
        bool usesEtre = false)
        : base(infinitive)
    {
        PastParticiple = pastParticiple;
        _presentTense = presentTense;
        _imperative = imperative;
        _stems = stems;
        UsesEtre = usesEtre;
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
        Console.WriteLine(Constants.Tenses.Present.ToHeadline());
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
        Console.WriteLine(Constants.Tenses.Imperative.ToHeadline());
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

    protected override void PrintGeneralInfo()
    {
        base.PrintGeneralInfo();
        Console.WriteLine("irregular");
    }
}