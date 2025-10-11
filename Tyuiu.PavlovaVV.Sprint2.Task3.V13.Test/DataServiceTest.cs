using Tyuiu.PavlovaVV.Sprint2.Task3.V13.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.75, ds.Calculate(0));
        }
    }
}
