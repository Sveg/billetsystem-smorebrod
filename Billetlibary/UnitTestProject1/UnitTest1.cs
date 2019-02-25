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
            Bil bil = new Bil();
            // act
            decimal pris = bil.Pris();
            // Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            Bil bil = new Bil();
            // act
            string k�ret�j = bil.K�reT�j();
            // Assert
            Assert.AreEqual("bil", k�ret�j);
        }

    }
}
