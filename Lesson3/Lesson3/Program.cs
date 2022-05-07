using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemovingSpecifiedWord("Hello world", "world");
            RemovingExtraSpacesInStartAndEnd("  Hello world   ");
            AreTwoStringsAnagrams("niedziela", "dzielenia");
            FindDuplicateCharacterInString("Agnieszka");
            ReverseWord("Ala ma kota");
        }

        public static void RemovingSpecifiedWord(string example, string oldValue)
        {
            string yourWord = string.Empty;
            yourWord = example.Replace(oldValue, "    ");
            Console.WriteLine(yourWord);

        }
        public static void RemovingExtraSpacesInStartAndEnd(string example)
        {
            Console.WriteLine(example.Trim());
        }
        public static void AreTwoStringsAnagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Two words aren't anagrams");
            }
            string s1ToLower = s1.ToLower();
            string s2toLower = s2.ToLower();

            char[] fromS1 = s1ToLower.ToCharArray();
            char[] fromS2 = s2toLower.ToCharArray();

            Array.Sort(fromS1);
            Array.Sort(fromS2);

            string newWorld1 = new string(fromS1);
            string newWorld2 = new string(fromS2);

            if (newWorld1 == newWorld2)
            {
                Console.WriteLine($"Words {s1} and {s2} are anagrams!");
            }
            else
            {
                Console.WriteLine("Two words aren't anagrams");
            }

        }
        public static void FindDuplicateCharacterInString(string s1)
        {
            string s1ToLower = s1.ToLower();

            Dictionary<char, int> findDuplicates = new Dictionary<char, int>();

            foreach (char c in s1ToLower)
            {
                if (!findDuplicates.ContainsKey(c))
                {
                    findDuplicates.Add(c, 1);
                }
                else
                {
                    findDuplicates[c] = findDuplicates[c] + 1;

                }
            }
            string duplicateChars = string.Empty;
            string duplicateCharsWithoutAdditionalSemicolon = string.Empty;
            foreach (var c in findDuplicates)
            {
                if (c.Value > 1)
                {
                    duplicateChars = duplicateChars + c.Key + ',';
                }

                duplicateCharsWithoutAdditionalSemicolon = duplicateChars.Trim(',');

            }
            Console.WriteLine($"Zdublowane litery to: {duplicateCharsWithoutAdditionalSemicolon}.");

        }
        public static List<string> Split(string input, char separator)
        {
            var result = new List<string>();
            var currentIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == separator)
                {
                    var word = input.Substring(currentIndex, i - currentIndex);
                    result.Add(word);
                    currentIndex = i + 1;
                }
                else if (i == input.Length - 1)
                {
                    var word = input.Substring(currentIndex, input.Length - currentIndex);
                    result.Add(word);
                }

            }

            return result;
        }
        public static string Join(List<string> list, char separator)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
                if (i != list.Count - 1)
                {
                    sb.Append(separator);
                }
            }
            return sb.ToString();
        }

        public static List<string> Reverse(List<string> list)
        {
            var result = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                result.Add(list[i]);
            }

            return result;
        }
        public static void ReverseWord(string str)
        {
            var split = Split(str, ' ');
            var reverse = Reverse(split);
            var result = Join(reverse, ' ');

            Console.WriteLine(result);
        }

        public static void IsItAPalindrome()
        {

        }
    }

}
