using Tyuiu.PavlovaVV.Sprint2.Task5.V9.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            DataService ds = new DataService();
            int m = 9;
            int n = 8;
            string res = ds.FindDateOfNextDay(m, n);
            string wait = "0" + m + ".09";
            Assert.AreEqual(res, wait);
        }
    }
}
