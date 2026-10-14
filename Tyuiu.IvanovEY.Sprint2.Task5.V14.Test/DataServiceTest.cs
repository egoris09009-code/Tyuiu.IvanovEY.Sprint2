using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovEY.Sprint2.Task5.V14.Lib;

namespace Tyuiu.IvanovEY.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Вторник", ds.FindDayName(2, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));
            Assert.AreEqual("Понедельник", ds.FindDayName(2, 7));
        }
    }
}