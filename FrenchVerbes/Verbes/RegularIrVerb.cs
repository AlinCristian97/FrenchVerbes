namespace FrenchVerbes.Verbes;

public class RegularIrVerb : RegularVerb
{
    public RegularIrVerb(string infinitive)
        : base(infinitive)
    {
    }

    protected override string Ending => "ir";

    protected override string[] PresentTenseEndings =>
        new[] { "is", "is", "it", "issons", "issez", "issent" };
}