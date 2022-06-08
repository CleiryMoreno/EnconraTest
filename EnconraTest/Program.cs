using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortByFrecuency("xyzxya");

            //Console.WriteLine(sortString("ccccaaabd"));
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

    }
}
