using Tyuiu.IvanovEY.Sprint2.Task2.V8.Lib;

namespace Tyuiu.IvanovEY.Sprint2.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(10, 2));
            Assert.IsTrue(ds.CheckDotInShadedArea(4, 5));
            Assert.IsTrue(ds.CheckDotInShadedArea(7, 5));
            Assert.IsTrue(ds.CheckDotInShadedArea(14, 7));
            Assert.IsTrue(ds.CheckDotInShadedArea(7, 11));

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(10, 10));
            Assert.IsFalse(ds.CheckDotInShadedArea(9, 4));
        }
    }
}
