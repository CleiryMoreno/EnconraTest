using EncoraTest;
using NUnit.Framework;

namespace EncoraTestTesting
{
    
    public class SortingStringTest
    {
        [SetUp]
        public void Setup()
        {
        }
        public static string[] case1 = {
"dulgvgzwqg",
"gxtjtmtywr",
"hnlilnxiupgt",
"gzjotckivp",
"dpwwsdptae",
"pcscpilknb",
"btvyhhmf1f",
"artrtngxcr",
"nrtemcoadn",
"fkdsgnekft"
};
        public static string[] expectedOutCase1 =
              {
            "gggdlquvwz",
"tttgjmrwxy",
"iillnnghptux",
"cgijkoptvz",
"ddppwwaest",
"ccppbiklns",
"ffhh1bmtvy",
"rrrttacgnx",
"nnacdemort",
"ffkkdegnst",

};

        public static string[] case2 =
                       {
 "wzenwebuau",
"vokfxzynwl",
"neldfeyrxk",
"wgadfiodgs",
"ykiuvzfcbc"

        };

        public static string[] expectedOutCase2 =
          {
            "eeuuwwabnz",
"fklnovwxyz",
"eedfklnrxy",
"ddggafiosw",
"ccbfikuvyz",


        };
        [Test]
        public void sortingOperations()
        {
            int i = 0;
            foreach (string c in case1)
            {
                var result = SortingString.sortingOperations(c);

                Assert.AreEqual(result, expectedOutCase1[i]);
                i++;
            }
            }
        [Test]
        public void sortingOperations2()
        {
            int i = 0;
            foreach (string c in case2)
            {
                var result = SortingString.sortingOperations(c);

                Assert.AreEqual(result, expectedOutCase2[i]);
                i++;
            }
        }
        [Test]
        public void sortingOperationsWithNullValue()
        {
            string str = null;

                var result = SortingString.sortingOperations(str);

                Assert.AreEqual(result,"404");
                
            
        }
        [Test]
        public void sortingOperationsWitEmptyValue()
        {
            string str = string.Empty;

            var result = SortingString.sortingOperations(str);

            Assert.AreEqual(result, "404");

        }

            [Test]
            public void sortingOperationsWitEmptyValue1()
        {
            string str = "";

            var result = SortingString.sortingOperations(str);

            Assert.AreEqual(result, "404");


        }
        [Test]
        public void SortingWord()
        {
            int i = 0;
            foreach (string c in case1)
            {
                var result = SortingString.sortingWord(c);

                Assert.AreEqual(result, expectedOutCase1[i]);
                i++;
            }
        }
      

        [Test]
        public void SortingWord2()
        {
            int i = 0;
            foreach (string c in case2)
            {
                var result = SortingString.sortingWord(c);

                Assert.AreEqual(result, expectedOutCase2[i]);
                i++;
            }
        }
        [Test]
        public void SortingWordWithNullValue()
        {
            string str = null;

            var result = SortingString.sortingWord(str);

            Assert.AreEqual(result, "404");


        }
        [Test]
        public void SortingWordWitEmptyValue()
        {
            string str = string.Empty;

            var result = SortingString.sortingWord(str);

            Assert.AreEqual(result, "404");

        }

            [Test]
            public void SortingWordEmptyValue1()
        {
            string str = "";

            var result = SortingString.sortingWord(str);

            Assert.AreEqual(result,"404");


        }

    }
}
