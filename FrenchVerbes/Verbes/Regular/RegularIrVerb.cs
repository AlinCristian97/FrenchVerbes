namespace FrenchVerbes.Verbes;

public class RegularIrVerb : RegularVerb
{
    public RegularIrVerb(string infinitive) : base(infinitive) { }

    protected override string Ending => "ir";
    protected override string PastParticipleSuffix => "i";

    protected override string[] PresentTenseEndings => new[] { "is", "is", "it", "issons", "issez", "issent" };
    protected override string[] ImparfaitEndings => new[] { "issais", "issais", "issait", "issions", "issiez", "issaient" };
    protected override string[] FuturSimpleEndings => new[] { "ai", "as", "a", "ons", "ez", "ont" };
    protected override string[] ConditionnelPresentEndings => new[] { "ais", "ais", "ait", "ions", "iez", "aient" };
    protected override string[] ImperativeEndings => new[] { "is", "issons", "issez" };
}