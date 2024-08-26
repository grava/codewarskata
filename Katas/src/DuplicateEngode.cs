using System.Globalization;
namespace Kata;
    public class DuplicateEncoder
    {
        

        public static string DuplicateEncode(string word)
        {
            var builder = new StringBuilder();
            foreach (char c in word.ToLower(new CultureInfo("en-US", false)))
            {
                builder.Append(word.Count(x => x == c) > 1 ? ')' : '(');
            }
            return builder.ToString();
        }
    }
