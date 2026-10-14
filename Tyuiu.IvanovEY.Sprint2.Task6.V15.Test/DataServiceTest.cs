using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovEY.Sprint2.Task6.V15.Lib;

namespace Tyuiu.IvanovEY.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));
            Assert.AreEqual("Понедельник", ds.FindDayName(8));
            Assert.AreEqual("Понедельник", ds.FindDayName(365));
        }
    }
}