namespace FrenchVerbes;

public static class Constants
{
    public static class Verbs
    {
        public static class Irregular
        {
            public const string Etre = "être";
            public const string Avoir = "avoir";
            public const string Aller = "aller";
            public const string Faire = "faire";
            public const string Pouvoir = "pouvoir";
            public const string Vouloir = "vouloir";
            public const string Devoir = "devoir";
            public const string Savoir = "savoir";
            public const string Venir = "venir";
            public const string Voir = "voir";
            public const string Dire = "dire"; // not implemented yet
            public const string Prendre = "prendre"; // not implemented yet
            public const string Ecrire = "écrire"; // not implemented yet
            public const string Lire = "lire"; // not implemented yet
        }

        public static class Regular
        {
            public static class Er
            {
                public const string Manger = "manger";
            }

            public static class Ir
            {
                public const string Finir = "finir";
            }

            public static class Re
            {
                public const string Vendre = "vendre";
            }
        }
    }
    
    public static class VerbDescriptions
    {
        public static class Irregular
        {
            public const string Etre = "Être est le verbe le plus fondamental. Il exprime l'état, l'identité et sert d'auxiliaire pour de nombreux temps.";
            public const string Avoir = "Avoir exprime la possession. C'est aussi l'auxiliaire le plus utilisé pour former les temps composés.";
            public const string Aller = "Aller est un verbe de mouvement indispensable pour exprimer une destination ou le futur proche.";
            public const string Faire = "Faire est un verbe polyvalent qui exprime l'action de faire ou de fabriquer quelque chose. Il est aussi utilisé pour le temps météo, les sports et de nombreuses expressions idiomatiques.";
            public const string Pouvoir = "Pouvoir est un verbe modal essentiel qui exprime la capacité, la possibilité ou la permission de faire quelque chose.";
            public const string Vouloir = "Vouloir est un verbe modal fondamental qui exprime le désir, la volonté ou l'intention. Sa forme conditionnelle 'je voudrais' est utilisée pour les demandes polies.";
            public const string Devoir = "Devoir est un verbe modal exprimant l'obligation, la nécessité ou le devoir moral. Il sert à indiquer ce qu’il faut faire ou ce qui est attendu.";
            public const string Savoir = "Savoir est un verbe fondamental qui exprime la connaissance, la compétence ou la capacité à faire quelque chose. Il sert aussi à indiquer qu'on connaît un fait ou une information.";
            public const string Venir = "Venir est un verbe de mouvement fondamental qui exprime l'action de se déplacer vers un lieu. Il est également utilisé pour former le passé récent ('venir de') et diverses expressions idiomatiques.";
            public const string Voir = "Voir est un verbe fondamental exprimant la perception visuelle ou la compréhension. Il est également utilisé dans de nombreuses expressions idiomatiques et au sens figuré pour indiquer la connaissance ou la constatation.";

        }

        public static class Regular
        {
            public static class Er
            {
                public const string Manger = "Utilisé pour l'action de consommer de la nourriture. Attention à la prononciation douce du 'g' dans toutes ses formes.";
            }

            public static class Ir
            {
                public const string Finir = "Exprime l'aboutissement d'une action, la fin d'une tâche ou l'achèvement d'un processus commencé plus tôt.";
            }

            public static class Re
            {
                public const string Vendre = "Le verbe de base pour le commerce, signifiant l'échange d'un bien ou d'un service contre une rémunération.";
            }
        }
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

        public const string LeGuillementOuvrant = "«";
        public const string LeGuillementFermant = "»";
    }
    
    public static string Vowels = "aeiouéêëàâîïôûùh";
    public static string SectionDivider = "--------------------------------------------------";
    public static string SmallDivider = "---";
}
