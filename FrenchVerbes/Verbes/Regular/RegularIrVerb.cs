namespace FrenchVerbes.Verbes.Regular;

public class RegularIrVerb : RegularVerb
{
    public RegularIrVerb(string infinitive, string description, NotesObject? tensesNotes = null) : base(infinitive,
        description, tensesNotes)
    {
        
    }

    private const string StemSuffix = "iss";
    
    protected override string Ending => "ir";
    protected override string PastParticipleSuffix => "i";

    protected override string[] PresentTenseEndings => new[] { "is", "is", "it", "issons", "issez", "issent" };
    protected override string[] ImperativeEndings => new[] { "is", "issons", "issez" };
    
    protected override string GetStemForTense(string tense) =>
        tense switch
        {
            Constants.Tenses.Imparfait => Infinitive[..^Ending.Length] + StemSuffix,
            _ => base.GetStemForTense(tense)
        };
}