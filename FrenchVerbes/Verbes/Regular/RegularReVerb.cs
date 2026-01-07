namespace FrenchVerbes.Verbes.Regular;

public class RegularReVerb : RegularVerb
{
    public RegularReVerb(string infinitive, string description) : base(infinitive, description) { }

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
}
