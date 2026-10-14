using Tyuiu.IvanovEY.Sprint2.Task4.V14.Lib;

namespace Tyuiu.IvanovEY.Sprint2.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(81, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double res = ds.Calculate(x, y);
            Assert.IsNotNull(res);
        }
    }
}