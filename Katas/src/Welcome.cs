namespace Kata
{
    public static class DB
    {
        private static Dictionary<string, string> dict = new Dictionary<string, string>{
              {"english", "Welcome"}
            , {"czech", "Vitejte"}
            , {"danish", "Velkomst"}
            , {"dutch", "Welkom"}
            , {"estonian", "Tere tulemast"}
            , {"finnish", "Tervetuloa"}
            , {"flemish", "Welgekomen"}
            , {"french", "Bienvenue"}
            , {"german", "Willkommen"}
            , {"irish", "Failte"}
            , {"italian", "Benvenuto"}
            , {"latvian", "Gaidits"}
            , {"lithuanian", "Laukiamas"}
            , {"polish", "Witamy"}
            , {"spanish", "Bienvenido"}
            , {"swedish", "Valkommen"}
            , {"welsh", "Croeso"}
            };

        public static Dictionary<string, string> Dict
        {
            get
            {
                return dict;
            }
        }
    }

    public class Welcome
    {
        public static string Greet(string language)
        {
            string defaultLanguage = "english";
            return DB.Dict.ContainsKey(language) ? DB.Dict[language] : DB.Dict[defaultLanguage];
        }
    }
}