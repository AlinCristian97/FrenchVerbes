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
            public const string Dire = "dire";
            public const string Prendre = "prendre";
            public const string Ecrire = "écrire";
            public const string Lire = "lire";
            //... more to come
        }

        public static class Regular
        {
            public static class Er
            {
                // A
                public const string Acheter = "acheter";
                public const string Aimer = "aimer";
                public const string Appeler = "appeler";
                public const string Arriver = "arriver";
                public const string Attendre = "attendre";

                // C
                public const string Changer = "changer";
                public const string Chercher = "chercher";
                public const string Commencer = "commencer";
                public const string Continuer = "continuer";
                public const string Créer = "créer";

                // D
                public const string Demander = "demander";
                public const string Discuter = "discuter";
                public const string Donner = "donner";
                public const string Détester = "détester";

                // É / E
                public const string Écouter = "écouter";
                public const string Entrer = "entrer";
                public const string Espérer = "espérer";
                public const string Essayer = "essayer";
                public const string Étudier = "étudier";
                public const string Expliquer = "expliquer";

                // F
                public const string Fermer = "fermer";

                // G
                public const string Garder = "garder";

                // H
                public const string Habiter = "habiter";

                // I
                public const string Imaginer = "imaginer";
                public const string Inviter = "inviter";

                // J
                public const string Jouer = "jouer";

                // M
                public const string Marcher = "marcher";
                public const string Manger = "manger";
                public const string Montrer = "montrer";

                // O
                public const string Organiser = "organiser";
                public const string Oublier = "oublier";
                public const string Ouvrir = "ouvrir";

                // P
                public const string Parler = "parler";
                public const string Passer = "passer";
                public const string Payer = "payer";
                public const string Penser = "penser";
                public const string Porter = "porter";
                public const string Préparer = "préparer";
                public const string Préférer = "préférer";

                // R
                public const string Raconter = "raconter";
                public const string Regarder = "regarder";
                public const string Rencontrer = "rencontrer";
                public const string Rester = "rester";
                public const string Retourner = "retourner";

                // S
                public const string Saluer = "saluer";
                public const string Souhaiter = "souhaiter";

                // T
                public const string Travailler = "travailler";
                public const string Trouver = "trouver";

                // U
                public const string Utiliser = "utiliser";

                // V
                public const string Voyager = "voyager";
                //... more to come
            }

            public static class Ir
            {
                // A
                public const string Agrandir = "agrandir";
                public const string Applaudir = "applaudir";

                // B
                public const string Bâtir = "bâtir";

                // C
                public const string Choisir = "choisir";

                // F
                public const string Finir = "finir";

                // G
                public const string Grandir = "grandir";
                public const string Grossir = "grossir";

                // N
                public const string Nourrir = "nourrir";

                // O
                public const string Obéir = "obéir";

                // P
                public const string Punir = "punir";

                // R
                public const string Réfléchir = "réfléchir";
                public const string Réussir = "réussir";
                public const string Remplir = "remplir";
                public const string Rougir = "rougir";

                // V
                public const string Vieillir = "vieillir";
                
                //... more to come
            }

            public static class Re
            {
                // A
                public const string Attendre = "attendre";

                // C
                public const string Comprendre = "comprendre";
                public const string Confondre = "confondre";
                public const string Conduire = "conduire"; // note: slightly irregular in forms, still common

                // D
                public const string Descendre = "descendre";
                public const string Défendre = "défendre";

                // P
                public const string Perdre = "perdre";
                public const string Prétendre = "prétendre";

                // R
                public const string Rendre = "rendre";
                public const string Répondre = "répondre";
                public const string Rejoindre = "rejoindre";

                // V
                public const string Vendre = "vendre";
                
                //... more to come
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
            public const string Dire = "Dire est un verbe fondamental exprimant l'action de prononcer, raconter ou communiquer quelque chose. Il est également utilisé dans de nombreuses expressions idiomatiques et pour rapporter des paroles.";
            public const string Prendre = "Prendre est un verbe fondamental exprimant l'action de saisir, obtenir ou consommer quelque chose. Il est également utilisé dans de nombreuses expressions idiomatiques et constructions figurées.";

        }

        public static class Regular
        {
            public static class Er
            {
                // A
                public const string Acheter = "Acheter est un verbe courant qui exprime l'action d'acquérir quelque chose en échange d'argent. Il est très utilisé dans la vie quotidienne, notamment pour parler de courses, de biens et de services.";
                public const string Aimer = "Aimer est un verbe régulier en -er qui exprime le sentiment d'affection, de goût ou de préférence. Très utilisé en français courant, il peut être suivi d'une personne, d'une chose ou d'une activité.";
                public const string Appeler = "Appeler est un verbe régulier en -er avec un changement orthographique : le 'l' se double pour certaines personnes afin de préserver le son [ɛ]. Il exprime l'action de nommer quelqu'un ou de téléphoner à quelqu'un.";

                // M
                public const string Manger = "Utilisé pour l'action de consommer de la nourriture. Attention à la prononciation douce du 'g' dans toutes ses formes.";
            }

            public static class Ir
            {
                // A
                public const string Agrandir = "Agrandir est un verbe régulier en -ir qui exprime l'action de rendre plus grand ou plus spacieux. Il est utilisé pour parler d'objets, de lieux ou de concepts qui prennent de l'ampleur.";
                public const string Applaudir = "Applaudir est un verbe régulier en -ir qui exprime l'action de frapper dans ses mains pour montrer son approbation ou son admiration, généralement après un spectacle ou une performance.";

                
                // F
                public const string Finir = "Exprime l'aboutissement d'une action, la fin d'une tâche ou l'achèvement d'un processus commencé plus tôt.";
            }

            public static class Re
            {
                // A
                public const string Attendre = "Attendre est un verbe régulier en -re qui exprime l'action de rester quelque part jusqu'à ce que quelque chose se produise ou que quelqu'un arrive. Il est utilisé pour parler de patience, de délai ou d'attente d'événements.";
                
                // C
                public const string Comprendre = "Comprendre est un verbe irrégulier en -re qui exprime l'action de saisir intellectuellement quelque chose, de percevoir le sens ou la signification. Il est construit comme 'prendre' pour ses conjugaisons.";

                
                // V
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
    
    public const string Vowels = "aeiouéêëàâîïôûùh";
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
