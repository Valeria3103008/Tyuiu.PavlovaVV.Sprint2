using Tyuiu.PavlovaVV.Sprint2.Task5.V9.Lib;
namespace Tyuiu.PavlovaVV.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнилa: Павлова П. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");

            int Month, Day;

            Console.WriteLine("Введите номер месяца: ");
            Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня: ");
            Day = Convert.ToInt32(Console.ReadLine());

            if ((Month > 12 || Day > 31) || (Month % 2 != 0 && Day == 31) || (Month == 2 && Day > 28))
            {
                Console.WriteLine("Такой даты не существует.");
            }
            else
            {
                Console.WriteLine(ds.FindDateOfNextDay(Month, Day));
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
        }
    }
}
