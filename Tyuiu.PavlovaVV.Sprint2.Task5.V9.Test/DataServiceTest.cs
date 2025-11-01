using Tyuiu.PavlovaVV.Sprint2.Task5.V9.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual("Четверг", dataService.FindDateOfNextDay(5, 1));
        }
    }
}
