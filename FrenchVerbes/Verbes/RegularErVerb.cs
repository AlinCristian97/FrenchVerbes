namespace FrenchVerbes.Verbes;

public class RegularErVerb : RegularVerb
{
    public RegularErVerb(string infinitive)
        : base(infinitive)
    {
    }

    protected override string Ending => "er";

    protected override string[] PresentTenseEndings =>
        new[] { "e", "es", "e", "ons", "ez", "ent" };
}
