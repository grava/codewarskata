using System.Collections;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;

public class Kata
{
    public static void Main() {
        DuplicateEncode("Success");
    }

    public static string DuplicateEncode(string word) {
        string res = "";
        var builder = new StringBuilder();
        foreach (char c in word.ToLower().ToCharArray()) {
            builder.Append(word.Count(x => x == c) > 1 ? ')' : '(');
        }
        return builder.ToString();
    }
  public static string OldDuplicateEncode(string word)
  {
    char[] arr = word.ToLower().ToCharArray();
    Dictionary<char,int> keys = new Dictionary<char,int>();
    char[] result = new char[arr.Length];

    for (var i =0; i<arr.Length; i++) {
      if (keys.ContainsKey(arr[i])) {
        result[i] = ')';
        if(keys[arr[i]]>=0) {
            result[keys[arr[i]]] = ')';
            keys[arr[i]]=-1;
        }
      } else {
        keys.Add(arr[i],i);
        result[i] = '(';
      }
    }
    word = new string(result);
    return word;
  }
}