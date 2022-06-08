using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncoraTest
{
   public static class SortingString
    {
        public static string sortingOperations(string inputString)
        {


            char[] tempArray = inputString.ToCharArray();
            string finalResult = string.Empty;

            Array.Sort(tempArray);
            var result = tempArray.GroupBy(n => n)
                          .OrderByDescending(g => g.Count())
                          .ThenBy(g => g.Key)
                          .SelectMany(g => g);
            finalResult = String.Join("", result);

            return finalResult;
        }
        static int getFrequency(string str, char ch)
        {
            var count = 0;

            for (var i = 0; i < str.Length; i++)

                if (str[i] == ch)
                    ++count;

            return count;
        }
        // using imperative programing/ loops
        public static string sortingWord(string str)
        {
            var result = string.Empty;
            var num = str.Length;
            var frequency = new Dictionary<char, int>();


            for (var i = 0; i < num; i++)
            {
                if (!frequency.ContainsKey(str[i]))
                    frequency.Add(str[i], getFrequency(str, str[i]));
            }

            var frecuencySorted = frequency.OrderBy(r => r.Key).OrderByDescending(r=>r.Value);


            foreach (var c in frecuencySorted)
                result += new string(c.Key, c.Value);

            return result;
        }


    }
}

