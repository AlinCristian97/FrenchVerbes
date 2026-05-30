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
        _verbs.Add(CreateInsister());
        _verbs.Add(CreateInspirer());
        _verbs.Add(CreateSe_Inspirer());
        _verbs.Add(CreateIndiquer());
        _verbs.Add(CreateInjurer());
        _verbs.Add(CreateInsulter());
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

    private static RegularErVerb CreateInsister()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Insister,
            Constants.VerbDescriptions.Regular.Er.Insister);
    }

    private static RegularErVerb CreateInspirer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Inspirer,
            Constants.VerbDescriptions.Regular.Er.Inspirer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Inspirer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Inspirer,
            Constants.VerbDescriptions.Regular.Er.Se_Inspirer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateIndiquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Indiquer,
            Constants.VerbDescriptions.Regular.Er.Indiquer);
    }

    private static RegularErVerb CreateInjurer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Injurer,
            Constants.VerbDescriptions.Regular.Er.Injurer);
    }

    private static RegularErVerb CreateInsulter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Insulter,
            Constants.VerbDescriptions.Regular.Er.Insulter);
    }

    #endregion
}

