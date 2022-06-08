using EncoraTest;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                  string[] array = {
                    "wzenwebuau",
                    "vokfxzynwl"
                            };                  
            foreach(String s in array) { 

        Console.WriteLine(SortingString.sortingOperations(s));
         Console.WriteLine(SortingString.sortingWord(s));
            }
        }




    }
}