using codeforcesRound805;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoundPrice.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10,codeforces.RoundDownthePrice(20));
            Assert.AreEqual(78, codeforces.RoundDownthePrice(178));
        }
    }
}