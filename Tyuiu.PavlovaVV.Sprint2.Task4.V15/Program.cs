using System;
using Tyuiu.PavlovaVV.Sprint2.Task4.V15.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            double res = ds.Calculate(x, y);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Значение переменной = " + res);


            Console.ReadKey();
        }
    }
}

