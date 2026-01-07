namespace FrenchVerbes;

public class NotesObject
{
    public string? PresentNotes { get; set; } = null;
    public string? ImparfaitNotes { get; set; } = null;
    public string? FuturSimpleNotes { get; set; } = null;
    public string? PasseComposeNotes { get; set; } = null;
    public string? FuturProcheNotes { get; set; } = null;
    public string? PasseRecentNotes { get; set; } = null;
    public string? ImperativeNotes { get; set; } = null;
    public string? ConditionnelPresentNotes { get; set; } = null;

    public NotesObject()
    {
    }

    public string? GetNotesForTense(string tense)
    {
        return tense switch
        {
            Constants.Tenses.Present => PresentNotes,
            Constants.Tenses.Imparfait => ImparfaitNotes,
            Constants.Tenses.FuturSimple => FuturSimpleNotes,
            Constants.Tenses.PasseCompose => PasseComposeNotes,
            Constants.Tenses.FuturProche => FuturProcheNotes,
            Constants.Tenses.PasseRecent => PasseRecentNotes,
            Constants.Tenses.Imperative => ImperativeNotes,
            Constants.Tenses.ConditionnelPresent => ConditionnelPresentNotes,
            _ => null
        };
    }
}