using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PavlovaVV.Sprint2.Task2.V26.Lib
{
    public class DataService : ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && x <= 13) && (y >= 3 && y <= 13))
            {
                if ((x >= 3 && x <= 5) && (y >= 8 && y <= 10))
                {
                    return false;
                }
                else if ((x >= 3 && x <= 6) && y == 12)
                {
                    return false;
                }
                else if (y == 13 && (x >= 3 && x <= 8))
                {
                    return false;
                }
                else if (y == 13 && (x >= 11 && x <= 13))
                {
                    return false;
                }
                else if ((y >= 11 && y <= 12) && x == 13)
                {
                    return false;
                }
                else if ((x >= 10 && x <= 13) && (y >= 9 && y <= 10))
                {
                    return false;
                }
                else if ((x >= 11 && x <= 13) && (y >= 4 && y <= 5))
                {
                    return false;
                }
                else if (x == 13 && y == 3)
                {
                    return false;
                }
                else if ((x >= 6 && x <= 8) && (y >= 3 && y <= 4))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
