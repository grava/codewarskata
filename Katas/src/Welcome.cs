namespace Kata
{

    public class Welcome
    {
        public static string Greet(string language)
        {
            string defaultLanguage = "english";
            return DB.Dict.ContainsKey(language) ? DB.Dict[language] : DB.Dict[defaultLanguage];
        }
    }
}