using System.Collections;
using System.Security.Cryptography;
using System.Collections.Generic;

public class Kata
{
    public static void Main() {
        DuplicateEncode("Success");
    }
  public static string DuplicateEncode(string word)
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