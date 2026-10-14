using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovEY.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = a > b;    // True (696 > 354)
            res[1] = a < b;    // False (696 < 354)
            res[2] = c < d;    // True (423 < 957)
            res[3] = b > c;    // False (354 > 423)
            res[4] = a >= c;   // True (696 >= 423)
            res[5] = a <= b;   // False (696 <= 354)

            return res;
        }
    }
}
