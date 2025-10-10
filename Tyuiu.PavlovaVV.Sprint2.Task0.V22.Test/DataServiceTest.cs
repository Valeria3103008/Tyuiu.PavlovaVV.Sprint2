using Tyuiu.PavlovaVV.Sprint2.Task0.V22.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService service1 = new DataService();
            int x = 2105;
            int y = 77;
            bool[] res = new bool[6];
            res = service1.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, true, true, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
