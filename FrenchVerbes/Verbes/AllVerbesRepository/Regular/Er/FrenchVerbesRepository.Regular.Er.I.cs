using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErIVerbs()
    {
        _verbs.Add(CreateImposer());
        _verbs.Add(CreateInfester());
        _verbs.Add(CreateInterpeller());
        _verbs.Add(CreateIdentifier());
    }

    #region FactoryMethods

    private static RegularErVerb CreateImposer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Imposer,
            Constants.VerbDescriptions.Regular.Er.Imposer);
    }

    private static RegularErVerb CreateInfester()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Infester,
            Constants.VerbDescriptions.Regular.Er.Infester);
    }

    private static RegularErVerb CreateInterpeller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Interpeller,
            Constants.VerbDescriptions.Regular.Er.Interpeller);
    }

    private static RegularErVerb CreateIdentifier()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Identifier,
            Constants.VerbDescriptions.Regular.Er.Identifier);
    }

    #endregion
}

