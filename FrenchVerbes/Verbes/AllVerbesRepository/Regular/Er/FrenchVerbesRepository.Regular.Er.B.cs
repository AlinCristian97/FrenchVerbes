using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErBVerbs()
    {
        _verbs.Add(CreateBeneficier());
        _verbs.Add(CreateBriller());
        _verbs.Add(CreateBombarder());
        _verbs.Add(CreateBouger());
        _verbs.Add(CreateBaptiser());
        _verbs.Add(CreateBarrer());
        _verbs.Add(CreateBaisser());
        _verbs.Add(CreateSe_Baisser());
        _verbs.Add(CreateBloquer());
        _verbs.Add(CreateSe_Bloquer());
        _verbs.Add(CreateBouder());
        _verbs.Add(CreateBriser());
    }

    #region FactoryMethods

    private static RegularErVerb CreateBeneficier()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Beneficier,
            Constants.VerbDescriptions.Regular.Er.Beneficier);
    }

    private static RegularErVerb CreateBriller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Briller,
            Constants.VerbDescriptions.Regular.Er.Briller);
    }

    private static RegularErVerb CreateBombarder()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Bombarder,
            Constants.VerbDescriptions.Regular.Er.Bombarder);
    }

    private static RegularErVerb CreateBouger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Bouger,
            Constants.VerbDescriptions.Regular.Er.Bouger,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Bouger prend un 'e' intercalaire devant les terminaisons commençant par 'a' ou 'o' pour conserver le son [ʒ] : nous bougeons — les autres formes du présent sont régulières.",
                ImparfaitNotes = "À l'imparfait, le 'e' intercalaire apparaît devant les terminaisons commençant par 'a' : je bougeais, tu bougeais, il bougeait, ils bougeaient — mais pas à la 1re et 2e personne du pluriel : nous bougions, vous bougiez."
            });
    }

    private static RegularErVerb CreateBaptiser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Baptiser,
            Constants.VerbDescriptions.Regular.Er.Baptiser);
    }

    private static RegularErVerb CreateBarrer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Barrer,
            Constants.VerbDescriptions.Regular.Er.Barrer);
    }

    private static RegularErVerb CreateBaisser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Baisser,
            Constants.VerbDescriptions.Regular.Er.Baisser,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Baisser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Baisser,
            Constants.VerbDescriptions.Regular.Er.Se_Baisser,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateBloquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Bloquer,
            Constants.VerbDescriptions.Regular.Er.Bloquer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Bloquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Bloquer,
            Constants.VerbDescriptions.Regular.Er.Se_Bloquer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateBouder()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Bouder,
            Constants.VerbDescriptions.Regular.Er.Bouder);
    }

    private static RegularErVerb CreateBriser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Briser,
            Constants.VerbDescriptions.Regular.Er.Briser);
    }

    #endregion
}

