using EncoraTest;
using NUnit.Framework;
using System;

namespace EncoraTestTesting
{
    
    public class SortingStringTest
    {
        const string expected = "404";
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void SortingOperationsCaseOne()
        {
          
            foreach (var c in StringTestCases.testCaseOne)
            {
                var result = SortingString.sortingOperations(c.Key);

                Assert.AreEqual(result, c.Value);
                Console.WriteLine($"Input:{c.Key} OutPut: {result} ");

            }
            }
        [Test]
        public void SortingOperationCaseTwo()
        {
          
            foreach (var c in StringTestCases.testCaseTwo)
            {
                var result = SortingString.sortingOperations(c.Key);

                Assert.AreEqual(result, c.Value);
                Console.WriteLine($"Input:{c.Key} OutPut: {result} ");

            }
        }
        [Test]
        public void SortingOperationsWithNullValue()
        {
            string str = null;

                var result = SortingString.sortingOperations(str);

                Assert.AreEqual(result, expected);
            Console.WriteLine($"Input:{str} OutPut: {result} ");


        }
        [Test]
        public void SortingOperationsWitEmptyValue()
        {
            string str = string.Empty;

            var result = SortingString.sortingOperations(str);

            Assert.AreEqual(result, expected);
            Console.WriteLine($"Input:{str} OutPut: {result} ");

        }

    
        [Test]
        public void SortingWordCaseOne()
        {
        
            foreach (var c in StringTestCases.testCaseOne)
            {
                var result = SortingString.sortingWord(c.Key);

                Assert.AreEqual(result,c.Value);
                Console.WriteLine($"Input:{c.Key} OutPut: {result} ");


            }
        }
      

        [Test]
        public void SortingWordCaseTwo()
        {
            
            foreach (var c in StringTestCases.testCaseTwo)
            {
                var result = SortingString.sortingWord(c.Key);

                Assert.AreEqual(result, c.Value);
                Console.WriteLine($"Input:{c.Key} OutPut: {result} ");

            }
        }
        [Test]
        public void SortingWordWithNullValue()
        {
            string str = null;

            var result = SortingString.sortingWord(str);

            Assert.AreEqual(result, expected);
            Console.WriteLine($"Input:{str} OutPut: {result} ");


        }
        [Test]
        public void SortingWordWitEmptyValue()
        {
            string str = string.Empty;

            var result = SortingString.sortingWord(str);

            Assert.AreEqual(result, expected);
            Console.WriteLine($"Input:{str} OutPut: {result} ");

        }

  

    }
}
