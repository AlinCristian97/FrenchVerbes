namespace FrenchVerbes.AllConstants;

public static partial class Constants
{
    public static class Pronouns
    {
        public const string Je = "Je";
        public const string Tu = "Tu";
        public const string IlElleOn = "Il/Elle/On";
        public const string Nous = "Nous";
        public const string Vous = "Vous";
        public const string IlsElles = "Ils/Elles";

        public static readonly string[] All = { Je, Tu, IlElleOn, Nous, Vous, IlsElles };

        public const string Je_Contracted = "J'";

        public static class Reflexive
        {
            // me / te elide to m' / t' before a vowel; se / s' always elide before a vowel.
            // These are the base forms — elision is applied at print time.
            public const string Me = "me";
            public const string Te = "te";
            public const string Se = "se";
            public const string Nous = "nous";
            public const string Vous = "vous";

            /// <summary>
            /// Indexed to match Constants.Pronouns.All:
            /// [0] je → me, [1] tu → te, [2] il/elle/on → se,
            /// [3] nous → nous, [4] vous → vous, [5] ils/elles → se
            /// </summary>
            public static readonly string[] All = { Me, Te, Se, Nous, Vous, Se };
        }
    }

    public static class Tenses
    {
        public const string Present = "Présent";
        public const string PasseCompose = "Passé Composé";
        public const string Imparfait = "Imparfait";
        public const string FuturProche = "Futur Proche";
        public const string FuturSimple = "Futur Simple";
        public const string ConditionnelPresent = "Conditionnel Présent";
        public const string PasseRecent = "Passé Récent";
        public const string Imperative = "Impératif";

        public static class Auxiliaries
        {
            public static readonly string[] FuturProche_Auxiliary = { "vais", "vas", "va", "allons", "allez", "vont" };
            public static readonly string[] PasseRecent_Auxiliary = { "viens", "viens", "vient", "venons", "venez", "viennent" };
            public static readonly string PasseRecent_Auxiliary_Connector = "de";
            public static readonly string[] PasseCompose_AuxiliaryAvoir = { "ai", "as", "a", "avons", "avez", "ont" };
            public static readonly string[] PasseCompose_AuxiliaryEtre = { "suis", "es", "est", "sommes", "êtes", "sont" };
        }
    }

    public static class FrenchSymbols
    {
        // Accents aigus
        public const string AiguE = "é";
        public const string AiguA = "á";
        public const string AiguI = "í";
        public const string AiguO = "ó";
        public const string AiguU = "ú";

        // Accents graves
        public const string GraveE = "è";
        public const string GraveA = "à";
        public const string GraveI = "ì";
        public const string GraveO = "ò";
        public const string GraveU = "ù";

        // Accents circonflexes
        public const string CircumflexE = "ê";
        public const string CircumflexA = "â";
        public const string CircumflexI = "î";
        public const string CircumflexO = "ô";
        public const string CircumflexU = "û";

        // Tréma
        public const string TremaE = "ë";
        public const string TremaI = "ï";
        public const string TremaU = "ü";
        public const string TremaY = "ÿ";

        // Cédille
        public const string CedillaC = "ç";

        // Ligatures
        public const string AeLigature = "æ";
        public const string OeLigature = "œ";

        public const string LeGuillementOuvrant = "«";
        public const string LeGuillementFermant = "»";
    }
    
    public const string Vowels = "aeiouéêëàâîïôûù";

    // Verbs beginning with h muet — elision applies (je → j')
    // Verbs beginning with h aspiré are NOT listed here — no elision (je hurle, je heurte...)
    public static readonly HashSet<string> HMuetVerbs =
    [
        Verbs.Regular.Er.Habiter,
        Verbs.Regular.Er.Habituer,
        Verbs.Regular.Er.Hésiter,
        Verbs.Regular.Er.Honorer,
        Verbs.Regular.Er.Hériter,
        Verbs.Regular.Er.Habiller,
    ];
    public const string SectionDivider = "--------------------------------------------------";
    public const string SmallDivider = "---";

    public static class VerbTypes
    {
        public const string Irregular = "irregular";
        public const string Regular = "regular";

        public static class RegularTypes
        {
            public const string Er = "er";
            public const string Ir = "ir";
            public const string Re = "re";
        }
    }
}
