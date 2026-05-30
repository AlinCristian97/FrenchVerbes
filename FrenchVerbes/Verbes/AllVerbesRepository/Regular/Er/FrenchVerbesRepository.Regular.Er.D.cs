using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErDVerbs()
    {
        _verbs.Add(CreateDenaturer());
        _verbs.Add(CreateDefigurer());
        _verbs.Add(CreateDeranger());
        _verbs.Add(CreateDebloquer());
        _verbs.Add(CreateSe_Debloquer());
        _verbs.Add(CreateDebrouiller());
        _verbs.Add(CreateSe_Debrouiller());
        _verbs.Add(CreateDivaguer());
        _verbs.Add(CreateDebuter());
        _verbs.Add(CreateDevorer());
        _verbs.Add(CreateDiner());
        _verbs.Add(CreateDetonner());
        _verbs.Add(CreateDeclencher());
        _verbs.Add(CreateDemander());
        _verbs.Add(CreateSe_Demander());
        _verbs.Add(CreateDiscuter());
        _verbs.Add(CreateDonner());
        _verbs.Add(CreateDeplacer());
        _verbs.Add(CreateSe_Deplacer());
        _verbs.Add(CreateDessiner());
        _verbs.Add(CreateDesigner());
        _verbs.Add(CreateDeferler());
        _verbs.Add(CreateDetester());
        _verbs.Add(CreateDurer());
        _verbs.Add(CreateDechainer());
        _verbs.Add(CreateSe_Dechainer());
        _verbs.Add(CreateDecider());
        _verbs.Add(CreateDejeuner());
        _verbs.Add(CreateDevelopper());
        _verbs.Add(CreateDeposer());
        _verbs.Add(CreateDerouler());
        _verbs.Add(CreateDemarrer());
        _verbs.Add(CreateDiminuer());
        _verbs.Add(CreateDominer());
        _verbs.Add(CreateDoubler());
        _verbs.Add(CreateDouter());
        _verbs.Add(CreateDeguster());
        _verbs.Add(CreateDeterminer());
        _verbs.Add(CreateDistinguer());
        _verbs.Add(CreateDebarrasser());
        _verbs.Add(CreateDetailler());
        _verbs.Add(CreateDegager());
        _verbs.Add(CreateDenommer());
        _verbs.Add(CreateDiriger());
        _verbs.Add(CreateDemontrer());
        _verbs.Add(CreateDeceler());
        _verbs.Add(CreateDevaster());
        _verbs.Add(CreateDefier());
        _verbs.Add(CreateDepecher());
        _verbs.Add(CreateSe_Depecher());
    }

    #region FactoryMethods

    private static RegularErVerb CreateDenaturer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Denaturer,
            Constants.VerbDescriptions.Regular.Er.Denaturer);
    }

    private static RegularErVerb CreateDefigurer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Defigurer,
            Constants.VerbDescriptions.Regular.Er.Defigurer);
    }

    private static RegularErVerb CreateDeranger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Deranger,
            Constants.VerbDescriptions.Regular.Er.Deranger);
    }

    private static RegularErVerb CreateDebloquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Debloquer,
            Constants.VerbDescriptions.Regular.Er.Debloquer);
    }

    private static RegularErVerb CreateSe_Debloquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Debloquer,
            Constants.VerbDescriptions.Regular.Er.Se_Debloquer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateDebrouiller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Debrouiller,
            Constants.VerbDescriptions.Regular.Er.Debrouiller,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Debrouiller()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Debrouiller,
            Constants.VerbDescriptions.Regular.Er.Se_Debrouiller,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateDivaguer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Divaguer,
            Constants.VerbDescriptions.Regular.Er.Divaguer);
    }

    private static RegularErVerb CreateDebuter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Debuter,
            Constants.VerbDescriptions.Regular.Er.Debuter);
    }

    private static RegularErVerb CreateDevorer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Devorer,
            Constants.VerbDescriptions.Regular.Er.Devorer);
    }

    private static RegularErVerb CreateDiner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Diner,
            Constants.VerbDescriptions.Regular.Er.Diner);
    }

    private static RegularErVerb CreateDetonner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Detonner,
            Constants.VerbDescriptions.Regular.Er.Detonner);
    }

    private static RegularErVerb CreateDeclencher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Declencher,
            Constants.VerbDescriptions.Regular.Er.Declencher);
    }

    private static RegularErVerb CreateDemander()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Demander,
            Constants.VerbDescriptions.Regular.Er.Demander,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Demander()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Demander,
            Constants.VerbDescriptions.Regular.Er.Se_Demander,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateDiscuter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Discuter,
            Constants.VerbDescriptions.Regular.Er.Discuter);
    }

    private static RegularErVerb CreateDonner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Donner,
            Constants.VerbDescriptions.Regular.Er.Donner);
    }

    private static RegularErVerb CreateDeplacer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Deplacer,
            Constants.VerbDescriptions.Regular.Er.Deplacer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Deplacer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Deplacer,
            Constants.VerbDescriptions.Regular.Er.Se_Deplacer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateDessiner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Dessiner,
            Constants.VerbDescriptions.Regular.Er.Dessiner);
    }

    private static RegularErVerb CreateDesigner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Designer,
            Constants.VerbDescriptions.Regular.Er.Designer);
    }

    private static RegularErVerb CreateDeferler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Deferler,
            Constants.VerbDescriptions.Regular.Er.Deferler);
    }

    private static RegularErVerb CreateDetester()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Detester,
            Constants.VerbDescriptions.Regular.Er.Detester);
    }

    private static RegularErVerb CreateDurer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Durer,
            Constants.VerbDescriptions.Regular.Er.Durer);
    }

    private static RegularErVerb CreateDechainer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Dechainer,
            Constants.VerbDescriptions.Regular.Er.Dechainer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Dechainer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Dechainer,
            Constants.VerbDescriptions.Regular.Er.Se_Dechainer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateDecider()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Decider,
            Constants.VerbDescriptions.Regular.Er.Decider);
    }

    private static RegularErVerb CreateDejeuner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Dejeuner,
            Constants.VerbDescriptions.Regular.Er.Dejeuner);
    }

    private static RegularErVerb CreateDevelopper()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Developper,
            Constants.VerbDescriptions.Regular.Er.Developper);
    }

    private static RegularErVerb CreateDeposer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Deposer,
            Constants.VerbDescriptions.Regular.Er.Deposer);
    }

    private static RegularErVerb CreateDerouler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Derouler,
            Constants.VerbDescriptions.Regular.Er.Derouler);
    }

    private static RegularErVerb CreateDemarrer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Demarrer,
            Constants.VerbDescriptions.Regular.Er.Demarrer);
    }

    private static RegularErVerb CreateDiminuer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Diminuer,
            Constants.VerbDescriptions.Regular.Er.Diminuer);
    }

    private static RegularErVerb CreateDominer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Dominer,
            Constants.VerbDescriptions.Regular.Er.Dominer);
    }

    private static RegularErVerb CreateDoubler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Doubler,
            Constants.VerbDescriptions.Regular.Er.Doubler);
    }

    private static RegularErVerb CreateDouter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Douter,
            Constants.VerbDescriptions.Regular.Er.Douter);
    }

    private static RegularErVerb CreateDeguster()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Deguster,
            Constants.VerbDescriptions.Regular.Er.Deguster);
    }

    private static RegularErVerb CreateDeterminer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Determiner,
            Constants.VerbDescriptions.Regular.Er.Determiner);
    }

    private static RegularErVerb CreateDistinguer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Distinguer,
            Constants.VerbDescriptions.Regular.Er.Distinguer);
    }

    private static RegularErVerb CreateDebarrasser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Debarrasser,
            Constants.VerbDescriptions.Regular.Er.Debarrasser);
    }

    private static RegularErVerb CreateDetailler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Detailler,
            Constants.VerbDescriptions.Regular.Er.Detailler);
    }

    private static RegularErVerb CreateDegager()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Degager,
            Constants.VerbDescriptions.Regular.Er.Degager);
    }

    private static RegularErVerb CreateDenommer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Denommer,
            Constants.VerbDescriptions.Regular.Er.Denommer);
    }

    private static RegularErVerb CreateDiriger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Diriger,
            Constants.VerbDescriptions.Regular.Er.Diriger);
    }

    private static RegularErVerb CreateDemontrer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Demontrer,
            Constants.VerbDescriptions.Regular.Er.Demontrer);
    }

    private static RegularErVerb CreateDeceler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Deceler,
            Constants.VerbDescriptions.Regular.Er.Deceler);
    }

    private static RegularErVerb CreateDevaster()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Devaster,
            Constants.VerbDescriptions.Regular.Er.Devaster);
    }

    private static RegularErVerb CreateDefier()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Defier,
            Constants.VerbDescriptions.Regular.Er.Defier);
    }

    private static RegularErVerb CreateDepecher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Depecher,
            Constants.VerbDescriptions.Regular.Er.Depecher,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Depecher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Depecher,
            Constants.VerbDescriptions.Regular.Er.Se_Depecher,
            usesEtre: true,
            isReflexive: true);
    }

    #endregion
}

