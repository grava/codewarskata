namespace Kata;
public static class DB
{
    private static readonly Dictionary<string, string> dict = new Dictionary<string, string>{
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
        get => dict;
    }
}
