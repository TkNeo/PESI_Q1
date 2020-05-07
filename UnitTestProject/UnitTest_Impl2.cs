using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PESI_Q1;


namespace PESI_Q1_UnitTesting
{
    [TestClass]
    public class UnitTest_Impl2
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Null was allowed")]
        //Test that ArgumentNullException exception is thrown when null is passed
        public void TestMethod1()
        {
            Program.StringRandomizer_Impl2(null);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var initialString = "";
            var randomzedStr = Program.StringRandomizer_Impl2(initialString);
            Assert.AreEqual<string>(initialString, randomzedStr);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var initialString = "a";
            var randomzedStr = Program.StringRandomizer_Impl2(initialString);
            Assert.AreEqual<string>(initialString, randomzedStr);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var initialString = "pesi";
            var randomzedStr = Program.StringRandomizer_Impl2(initialString);
            Assert.AreNotEqual<string>(initialString, randomzedStr);
        }


        [TestMethod]
        //Tests that the shuffling logic is not adding / removing any characters as a bug.
        public void TestMethod5()
        {
            var initialString = "tarunkapoor";
            var randomzedStr = Program.StringRandomizer_Impl2(initialString);

            var initial_arr = initialString.ToCharArray().OrderBy(x => x);
            var randomized_arr = randomzedStr.ToCharArray().OrderBy(y => y);
            Assert.AreEqual(initial_arr.SequenceEqual(randomized_arr), true);
        }

    }
}
