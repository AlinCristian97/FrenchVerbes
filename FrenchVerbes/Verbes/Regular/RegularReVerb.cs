namespace FrenchVerbes.Verbes.Regular;

public class RegularReVerb : RegularVerb
{
    public RegularReVerb(string infinitive, string description, NotesObject? tensesNotes = null) : base(infinitive,
        description, tensesNotes)
    {
        
    }

    protected override string Ending => "re";
    protected override string PastParticipleSuffix => "u";
    
    protected override string[] PresentTenseEndings => new[] { "s", "s", "", "ons", "ez", "ent" };
    protected override string[] ImperativeEndings => new[] { "s", "ons", "ez" };
    
    protected override string GetStemForTense(string tense) =>
        tense switch
        {
            Constants.Tenses.Present => Infinitive[..^Ending.Length],
            Constants.Tenses.Imparfait => Infinitive[..^Ending.Length],
            Constants.Tenses.FuturSimple => Infinitive[..^1],
            Constants.Tenses.ConditionnelPresent => Infinitive[..^1],
            _ => Infinitive
        };
    
    protected override string PastParticiple => Infinitive switch
    {
        Constants.Verbs.Regular.Re.Comprendre => "compris",
        "apprendre"  => "appris", // use const
        "reprendre"  => "repris", // use const
        _ => Infinitive[..^Ending.Length] + PastParticipleSuffix
    };
    
    private static readonly Dictionary<string, string[]> PresentStemExceptions = new()
    {
        [Constants.Verbs.Regular.Re.Comprendre] = new[] { "comprends", "comprends", "comprend", "comprenons", "comprenez", "comprennent" },
        ["apprendre"]  = new[] { "apprends", "apprends", "apprend", "apprenons", "apprenez", "apprennent" },
        ["reprendre"]  = new[] { "reprends", "reprends", "reprend", "reprenons", "reprenez", "reprennent" }
    };
    
    protected string GetPresentForm(int pronounIndex)
    {
        if (PresentStemExceptions.TryGetValue(Infinitive, out var forms))
            return forms[pronounIndex];

        // fallback to regular -re rules
        string stem = Infinitive[..^Ending.Length];
        return stem + PresentTenseEndings[pronounIndex];
    }
    
    protected override void PrintPresent()
    {
        string tense = Constants.Tenses.Present;
        PrintUtils.PrintHeadline(tense);
        PrintNotesForTenseIfAny(tense);

        for (int i = 0; i < Constants.Pronouns.All.Length; i++)
        {
            string form = GetPresentForm(i);
            PrintUtils.PrintPronoun(i, form);
            Console.WriteLine(form);
        }
    }
}
