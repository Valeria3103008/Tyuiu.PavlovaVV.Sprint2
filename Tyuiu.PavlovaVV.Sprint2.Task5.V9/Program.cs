using Tyuiu.PavlovaVV.Sprint2.Task5.V9.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.WriteLine("Введите номер месяца: ");
            int numMounth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер дня: ");
            int numDay = Convert.ToInt32(Console.ReadLine());

            string res;


            if ((((numMounth < 1) || (numMounth > 12)) && ((numDay < 1) || (numDay > 30))) && ((numMounth == 4) || (numMounth == 9) || (numMounth == 6) || (numMounth == 11)))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = ds.FindDateOfNextDay(numMounth);
            }

            if ((((numMounth < 1) || (numMounth > 12)) && ((numDay < 1) || (numDay > 31))) && ((numMounth == 1) || (numMounth == 2) || (numMounth == 5) || (numMounth == 11) || (numMounth == 7) || (numMounth == 8) || (numMounth == 10) || (numMounth == 12)))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = ds.FindDateOfNextDay(numMounth);
            }

            if ((((numMounth < 1) || (numMounth > 12)) && ((numDay < 1) || (numDay > 28))) && (numMounth == 2))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = ds.FindDateOfNextDay(numMounth);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Дата следующего дня= Месяц: " + ds.FindDateOfNextDay(numMounth) + " День: " + (numDay + 1));
            Console.ReadKey();

        }
    }
}
