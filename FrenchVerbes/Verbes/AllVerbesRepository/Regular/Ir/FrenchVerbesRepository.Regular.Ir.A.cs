using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularIrAVerbs()
    {
        _verbs.Add(CreateAccomplir());
        _verbs.Add(CreateAgrandir());
        _verbs.Add(CreateApplaudir());
    }

    #region FactoryMethods

    private static RegularIrVerb CreateAccomplir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Accomplir,
            Constants.VerbDescriptions.Regular.Ir.Accomplir);
    }

    private static RegularIrVerb CreateAgrandir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Agrandir,
            Constants.VerbDescriptions.Regular.Ir.Agrandir);
    }

    private static RegularIrVerb CreateApplaudir()
    {
        return new RegularIrVerb(
            Constants.Verbs.Regular.Ir.Applaudir,
            Constants.VerbDescriptions.Regular.Ir.Applaudir);
    }

    #endregion
}
