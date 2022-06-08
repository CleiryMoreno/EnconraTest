using EncoraTest;
using NUnit.Framework;

namespace EncoraTestTesting
{
    
    public class Tests
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
        public void SortingStringCase1()
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
        public void SortingStringCase2()
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
      
    }
}
