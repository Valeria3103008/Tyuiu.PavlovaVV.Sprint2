using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PavlovaVV.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string res;
            if (m >= 1 && m <= 12)
            {
                switch (n)
                {
                    case 1:
                        res = "0" + m + ".02 ";
                        break;
                    case 2:
                        res = "0" + m + ".03";
                        break;
                    case 3:
                        res = "0" + m + ".04";
                        break;
                    case 4:
                        res = "0" + m + ".05";
                        break;
                    case 5:
                        res = "0" + m + ".06";
                        break;
                    case 6:
                        res = "0" + m + ".07";
                        break;
                    case 7:
                        res = "0" + m + ".08";
                        break;
                    case 8:
                        res = "0" + m + ".09";
                        break;
                    case 9:
                        res = "0" + m + ".10";
                        break;
                    case 10:
                        res = "0" + m + ".11";
                        break;
                    case 11:
                        res = "0" + m + ".12";
                        break;
                    case 12:
                        res = "0" + m + ".13";
                        break;
                    case 13:
                        res = "0" + m + ".14";
                        break;
                    case 14:
                        res = "0" + m + ".15";
                        break;
                    case 15:
                        res = "0" + m + ".16";
                        break;
                    case 16:
                        res = "0" + m + ".17";
                        break;
                    case 17:
                        res = "0" + m + ".18";
                        break;
                    case 18:
                        res = "0" + m + ".19";
                        break;
                    case 19:
                        res = "0" + m + ".20";
                        break;
                    case 20:
                        res = "0" + m + ".21";
                        break;
                    case 21:
                        res = "0" + m + ".22";
                        break;
                    case 22:
                        res = "0" + m + ".23";
                        break;
                    case 23:
                        res = "0" + m + ".24";
                        break;
                    case 24:
                        res = "0" + m + ".25";
                        break;
                    case 25:
                        res = "0" + m + ".26";
                        break;
                    case 26:
                        res = "0" + m + ".27";
                        break;
                    case 27:
                        res = "0" + m + ".28";
                        break;
                    case 28:
                        res = "0" + m + ".29";
                        break;
                    case 29:
                        res = "0" + m + ".30";
                        break;
                    case 30:
                        res = "0" + m + ".31";
                        break;
                    case 31:
                        res = "0" + m + 1 + ".1";
                        break;
                    default:
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение {n}");
                }
            }
            else
            {
                res = "0";
            }
            return res;
        }
    }
}
