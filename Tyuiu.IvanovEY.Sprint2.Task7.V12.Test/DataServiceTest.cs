using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovEY.Sprint2.Task7.V12.Lib;

namespace Tyuiu.IvanovEY.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точка внутри верхней левой области
            Assert.IsTrue(ds.CheckDotInShadedArea(-3, 7));

            // Точка внутри нижней средней области
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, 1));

            // Точка вне области
            Assert.IsFalse(ds.CheckDotInShadedArea(5, 5));
        }
    }
}