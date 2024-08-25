namespace Kata
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            string res = "";
            var builder = new StringBuilder();
            foreach (char c in word.ToLower().ToCharArray())
            {
                builder.Append(word.Count(x => x == c) > 1 ? ')' : '(');
            }
            return builder.ToString();
        }
    }
}