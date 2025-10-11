using Tyuiu.PavlovaVV.Sprint2.Task0.V22.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3105;
            int y = 77;
            bool[] res = new bool[6];
            res = service1.GetCompareOperations(x, y);
            Console.WriteLine("x=" + x + " y=" + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
