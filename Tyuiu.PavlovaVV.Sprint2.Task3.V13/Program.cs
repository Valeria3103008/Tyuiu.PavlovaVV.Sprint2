using Tyuiu.PavlovaVV.Sprint2.Task3.V13.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task3.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите x:");
            var x = Convert.ToDouble(Console.ReadLine());
            var result = ds.Calculate(x);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
