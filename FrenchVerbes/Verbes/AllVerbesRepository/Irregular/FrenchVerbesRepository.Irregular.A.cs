namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddIrregularAVerbs()
    {
        _verbs.Add(CreateAvoir());
        _verbs.Add(CreateAtteindre());
        _verbs.Add(CreateAller());
        _verbs.Add(CreateCourir());
    }
}
