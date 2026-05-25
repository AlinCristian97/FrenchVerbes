using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErCVerbs()
    {
        _verbs.Add(CreateChanger());
        _verbs.Add(CreateCommencer());
    }

    #region FactoryMethods

    private static RegularErVerb CreateChanger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Changer,
            Constants.VerbDescriptions.Regular.Er.Changer);
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
                    "À l’imparfait, le verbe suit la même règle pour la première personne du pluriel : nous commencions."
            });
    }

    #endregion
}

