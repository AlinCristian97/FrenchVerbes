using FrenchVerbes.AllConstants;
using FrenchVerbes.Verbes.Regular;

namespace FrenchVerbes.Verbes;

public static partial class VerbRepository
{
    private static void AddRegularReDVerbs()
    {
        _verbs.Add(CreateDefendre());
        _verbs.Add(CreateDescendre());
    }

    #region FactoryMethods

    private static RegularReVerb CreateDefendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Defendre,
            Constants.VerbDescriptions.Regular.Re.Defendre
        );
    }

    private static RegularReVerb CreateDescendre()
    {
        return new RegularReVerb(
            Constants.Verbs.Regular.Re.Descendre,
            Constants.VerbDescriptions.Regular.Re.Descendre,
            usesEtre: true,
            tensesNotes: new NotesObject
            {
                PasseComposeNotes = "Descendre se conjugue généralement avec l'auxiliaire 'être' au passé composé pour exprimer un mouvement : je suis descendu(e). Si le verbe a un complément direct, on utilise 'avoir' : j'ai descendu les escaliers.",
                PresentNotes = "Descendre est régulier au présent : je descends, tu descends, il descend, nous descendons, vous descendez, ils descendent."
            });
    }

    #endregion
}

