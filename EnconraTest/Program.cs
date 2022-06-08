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
                  string[] case1 = {
"wzenwebuau",
"vokfxzynwl",
"neldfeyrxk",
"wgadfiodgs",
"ykiuvzfcbc"
};                  
            foreach(String s in case1) { 

        Console.WriteLine(SortingString.sortingOperations(s));
           // Console.WriteLine(SortingString.sortingWord(s));
            }
        }




    }
}