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
        _verbs.Add(CreateInformer());
        _verbs.Add(CreateImprimer());
        _verbs.Add(CreateImaginer());
        _verbs.Add(CreateInviter());
        _verbs.Add(CreateInstaller());
        _verbs.Add(CreateImporter());
        _verbs.Add(CreateInfliger());
        _verbs.Add(CreateIncarner());
        _verbs.Add(CreateInspecter());
        _verbs.Add(CreateIrriter());
        _verbs.Add(CreateSe_Irriter());
        _verbs.Add(CreateInteresser());
        _verbs.Add(CreateSe_Interesser());
        _verbs.Add(CreateImiter());
        _verbs.Add(CreateInterroger());
        _verbs.Add(CreateImplorer());
        _verbs.Add(CreateIgnorer());
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

    private static RegularErVerb CreateInformer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Informer,
            Constants.VerbDescriptions.Regular.Er.Informer);
    }

    private static RegularErVerb CreateImprimer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Imprimer,
            Constants.VerbDescriptions.Regular.Er.Imprimer);
    }

    private static RegularErVerb CreateImaginer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Imaginer,
            Constants.VerbDescriptions.Regular.Er.Imaginer);
    }

    private static RegularErVerb CreateInviter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Inviter,
            Constants.VerbDescriptions.Regular.Er.Inviter);
    }

    private static RegularErVerb CreateInstaller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Installer,
            Constants.VerbDescriptions.Regular.Er.Installer);
    }

    private static RegularErVerb CreateImporter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Importer,
            Constants.VerbDescriptions.Regular.Er.Importer);
    }

    private static RegularErVerb CreateInfliger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Infliger,
            Constants.VerbDescriptions.Regular.Er.Infliger);
    }

    private static RegularErVerb CreateIncarner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Incarner,
            Constants.VerbDescriptions.Regular.Er.Incarner);
    }

    private static RegularErVerb CreateInspecter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Inspecter,
            Constants.VerbDescriptions.Regular.Er.Inspecter);
    }

    private static RegularErVerb CreateIrriter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Irriter,
            Constants.VerbDescriptions.Regular.Er.Irriter,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Irriter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Irriter,
            Constants.VerbDescriptions.Regular.Er.Se_Irriter,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateInteresser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Interesser,
            Constants.VerbDescriptions.Regular.Er.Interesser,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Interesser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Interesser,
            Constants.VerbDescriptions.Regular.Er.Se_Interesser,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateImiter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Imiter,
            Constants.VerbDescriptions.Regular.Er.Imiter);
    }

    private static RegularErVerb CreateInterroger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Interroger,
            Constants.VerbDescriptions.Regular.Er.Interroger);
    }

    private static RegularErVerb CreateImplorer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Implorer,
            Constants.VerbDescriptions.Regular.Er.Implorer);
    }

    private static RegularErVerb CreateIgnorer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Ignorer,
            Constants.VerbDescriptions.Regular.Er.Ignorer);
    }

    #endregion
}

