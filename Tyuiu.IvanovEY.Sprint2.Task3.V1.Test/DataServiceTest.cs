using Tyuiu.IvanovEY.Sprint2.Task3.V1.Lib;

namespace Tyuiu.IvanovEY.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = Math.Round(Math.Exp(1) - 12 + Math.Cos(1), 3);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 2 + (15.0 / 2);
            Assert.AreEqual(Math.Round(wait, 3), res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = -2 + 10 * (-2) - (1.0 / -2);
            Assert.AreEqual(Math.Round(wait, 3), res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = -10 + 10 * (-10) - (1.0 / (Math.Pow(-10, 3) + 3));
            Assert.AreEqual(Math.Round(wait, 3), res);
        }
    }
}