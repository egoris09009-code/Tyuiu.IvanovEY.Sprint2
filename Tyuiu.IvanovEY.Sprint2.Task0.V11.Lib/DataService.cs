using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovEY.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + y == x + y; 
            res[1] = x != x;         
            res[2] = y < x;          
            res[3] = x > x;          
            res[4] = y <= x;         
            res[5] = y >= x;         
            return res;
        }
    }
}
