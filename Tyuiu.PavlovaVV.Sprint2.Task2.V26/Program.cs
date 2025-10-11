using Tyuiu.PavlovaVV.Sprint2.Task2.V26.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task2.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Введите x:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y:");
            var y = Convert.ToInt32(Console.ReadLine());

            var result = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
