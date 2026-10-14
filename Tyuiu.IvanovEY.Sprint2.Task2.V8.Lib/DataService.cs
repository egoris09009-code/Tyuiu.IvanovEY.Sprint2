using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovEY.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 1 || x > 15 || y < 1 || y > 15) return false;

            if ((x >= 9 && x <= 11) && (y >= 2 && y <= 3)) return true;
            if ((x == 12) && (y == 3)) return true;

            if ((x >= 3 && x <= 5) && (y >= 3 && y <= 7)) return true;

            if ((x >= 6 && x <= 9) && (y >= 5 && y <= 6)) return true;

            if ((x >= 10 && x <= 13) && (y >= 6 && y <= 7)) return true;
            if ((x == 14) && (y == 7)) return true;

            if ((x >= 12 && x <= 13) && (y == 8)) return true;

            if ((x >= 6 && x <= 8) && (y >= 7 && y <= 9)) return true;

            if ((x >= 3 && x <= 5) && (y >= 10 && y <= 11)) return true;
            if ((x >= 6 && x <= 9) && (y >= 10 && y <= 12)) return true;

            return false;
        }
    }
}
