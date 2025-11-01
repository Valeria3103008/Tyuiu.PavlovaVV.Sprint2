using Tyuiu.PavlovaVV.Sprint2.Task5.V9.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* Введите значние m:                                                       ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значние n:                                                       ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.FindDateOfNextDay(m, n));

            Console.ReadKey();
        }
    }
}
