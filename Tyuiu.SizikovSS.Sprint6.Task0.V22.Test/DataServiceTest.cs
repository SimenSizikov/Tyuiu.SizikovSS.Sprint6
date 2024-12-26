using Tyuiu.SizikovSS.Sprint6.Task0.V22.Lib;

namespace Tyuiu.SizikovSS.Sprint6.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(11.68, ds.Calculate(2));
        }
    }
}
