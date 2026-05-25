using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularErMVerbs()
    {
        _verbs.Add(CreateManger());
    }

    #region FactoryMethods

    private static RegularErVerb CreateManger()
    {
        return new RegularErVerb(
            Constants.Verbs.Regular.Er.Manger,
            Constants.VerbDescriptions.Regular.Er.Manger,
            tensesNotes: new NotesObject
            {
                PresentNotes = "Manger ajoute un 'e' devant la terminaison au présent avec 'nous' pour conserver le son doux du 'g' : nous mangeons."
            });
    }

    #endregion
}

