namespace FrenchVerbes;

public static class Constants
{
    public static class Verbs
    {
        public const string Etre = "être";
        public const string Avoir = "avoir";
        public const string Aller = "aller";
        public const string Manger = "manger";
        public const string Finir = "finir";
        public const string Vendre = "vendre";
    }

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
    }
}
