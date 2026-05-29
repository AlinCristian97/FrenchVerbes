using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErCVerbs()
    {
        _verbs.Add(CreateChanger());
        _verbs.Add(CreateCommencer());
        _verbs.Add(CreateCasser());
        _verbs.Add(CreateSe_Casser());
        _verbs.Add(CreateContempler());
        _verbs.Add(CreateConvoquer());
        _verbs.Add(CreateCurater());
        _verbs.Add(CreateCompenser());
        _verbs.Add(CreateCelebrer());
        _verbs.Add(CreateCooperer());
        _verbs.Add(CreateContourner());
        _verbs.Add(CreateCompter());
        _verbs.Add(CreateConferer());
        _verbs.Add(CreateCondamner());
        _verbs.Add(CreateSe_Changer());
        _verbs.Add(CreateChercher());
    }

    #region FactoryMethods

    private static RegularErVerb CreateChanger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Changer,
            Constants.VerbDescriptions.Regular.Er.Changer,
            hasReflexive: true);
    }

    private static RegularErVerb CreateCommencer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Commencer,
            Constants.VerbDescriptions.Regular.Er.Commencer,
            tensesNotes: new NotesObject
            {
                PresentNotes =
                    "Au présent, le verbe change le 'c' en 'ç' devant 'a' ou 'o' pour conserver le son doux : nous commençons.",
                ImparfaitNotes =
                    "À l'imparfait, le verbe suit la même règle pour la première personne du pluriel : nous commencions."
            });
    }

    private static RegularErVerb CreateCasser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Casser,
            Constants.VerbDescriptions.Regular.Er.Casser,
            hasReflexive: true);
    }

    private static RegularErVerb CreateSe_Casser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Casser,
            Constants.VerbDescriptions.Regular.Er.Se_Casser,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateContempler()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Contempler,
            Constants.VerbDescriptions.Regular.Er.Contempler);
    }

    private static RegularErVerb CreateConvoquer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Convoquer,
            Constants.VerbDescriptions.Regular.Er.Convoquer);
    }

    private static RegularErVerb CreateCurater()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Curater,
            Constants.VerbDescriptions.Regular.Er.Curater);
    }

    private static RegularErVerb CreateCompenser()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Compenser,
            Constants.VerbDescriptions.Regular.Er.Compenser);
    }

    private static RegularErVerb CreateCelebrer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Celebrer,
            Constants.VerbDescriptions.Regular.Er.Celebrer,
            tensesNotes: new NotesObject
            {
                PresentNotes =
                    "Au présent, célébrer s’écrit avec un accent grave (è) aux personnes je, tu, il/elle et ils/elles pour maintenir la prononciation du “e” ouvert.",
                ImparfaitNotes =
                    "À l'imparfait, le radical conserve le 'é' : je célébrais, nous célébrions."
            });
    }

    private static RegularErVerb CreateCooperer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Cooperer,
            Constants.VerbDescriptions.Regular.Er.Cooperer,
            tensesNotes: new NotesObject
            {
                PresentNotes =
                    "Au présent, coopérer s’écrit avec un accent grave (è) aux personnes je, tu, il/elle et ils/elles afin de conserver la prononciation ouverte du “e”.",
                ImparfaitNotes =
                    "À l'imparfait, le radical conserve le 'é' : je coopérais, nous coopérions."
            });
    }

    private static RegularErVerb CreateContourner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Contourner,
            Constants.VerbDescriptions.Regular.Er.Contourner);
    }

    private static RegularErVerb CreateCompter()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Compter,
            Constants.VerbDescriptions.Regular.Er.Compter);
    }

    private static RegularErVerb CreateConferer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Conferer,
            Constants.VerbDescriptions.Regular.Er.Conferer,
            tensesNotes: new NotesObject
            {
                PresentNotes =
                    "Au présent, conférer s'écrit avec un accent grave (è) aux personnes je, tu, il/elle et ils/elles pour maintenir la prononciation du \"e\" ouvert.",
                ImparfaitNotes =
                    "À l'imparfait, le radical conserve le 'é' : je conférais, nous conférions."
            });
    }

    private static RegularErVerb CreateCondamner()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Condamner,
            Constants.VerbDescriptions.Regular.Er.Condamner);
    }

    private static RegularErVerb CreateSe_Changer()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Se_Changer,
            Constants.VerbDescriptions.Regular.Er.Se_Changer,
            usesEtre: true,
            isReflexive: true);
    }

    private static RegularErVerb CreateChercher()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Chercher,
            Constants.VerbDescriptions.Regular.Er.Chercher);
    }

    #endregion
}