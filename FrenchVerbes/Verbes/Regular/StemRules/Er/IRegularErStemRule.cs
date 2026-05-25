namespace FrenchVerbes.Verbes.Regular.StemRules.Er;

public interface IRegularErStemRule
{
    string Infinitive { get; }
    string Apply(string stem, string tense, int pronounIndex);
}
