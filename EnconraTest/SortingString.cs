using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncoraTest
{
   public static class SortingString
    {
        //Using fucntional Programing
        public static string sortingOperations(string str)
        {
           
            string finalResult = "404";
            if (str != "" & str != null & str != string.Empty)
            {
                finalResult = string.Empty;
                char[] tempArray = str.ToCharArray();
                Array.Sort(tempArray);
                var result = tempArray.GroupBy(n => n)
                              .OrderByDescending(g => g.Count())
                              .ThenBy(g => g.Key)
                              .SelectMany(g => g);
                finalResult = String.Join("", result);
            }

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
            var result = "404";
            var num = 0;

            if (str!="" & str!= null & str != string.Empty){
              num = str.Length;
            var frequency = new Dictionary<char, int>();
            result = string.Empty;
            for (var i = 0; i < num; i++)
            {
                if (!frequency.ContainsKey(str[i]))
                    frequency.Add(str[i], getFrequency(str, str[i]));
            }

            var frecuencySorted = frequency.OrderBy(r => r.Key).OrderByDescending(r=>r.Value);


            foreach (var c in frecuencySorted)
                result += new string(c.Key, c.Value);
            }

            return result;
        }


    }
}

