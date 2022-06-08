using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine(sortString("ccccaaabd"));
          
          
        }



        public static void SortByFrecuency(string s)
        {


            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach (char i in s)
            {
                if (d.ContainsKey(i))
                {
                    d[i]++;
                }
                else
                {
                    d[i] = 1;
                }
            }



            foreach (char i in s)
            {

                if (d[i] != 0)
                {
                    string LetraRepetida = string.Empty;
                    int valor = int.Parse(d[i].ToString());

                    for (int x = 0; x < valor; x++)
                    {
                        LetraRepetida += i;
                    }


                    Console.Write(LetraRepetida);
                    d[i] = 0;
                }
            }
        }
        // Using Linq / Fuctional Programing
        public static string sortString(string inputString)
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

       

    }
}