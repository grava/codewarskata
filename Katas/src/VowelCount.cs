using System.Collections;
using System.Collections.Generic;

namespace Kata
{
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            var vowels = new ArrayList(new[]{ 'a', 'e', 'i', 'o', 'u' });

            int vowelCount = 0;

            vowelCount += str.Count(x => vowels.Contains(x));

            // Your code here

            return vowelCount;
        }
    }
}