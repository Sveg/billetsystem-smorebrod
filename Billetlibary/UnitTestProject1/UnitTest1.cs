using Microsoft.VisualStudio.TestTools.UnitTesting;
using Billetlibary;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            bil bil = new bil();
            // act
            decimal pris = bil.Pris();
            // Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            bil bil = new bil();
            // act
            string k�ret�j = bil.K�reT�j();
            // Assert
            Assert.AreEqual("bil", k�ret�j);
        }

    }
}
