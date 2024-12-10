using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShopenDD.Lab1.V19.Lib;

namespace Tyuiu.ShopenDD.Lab1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FirstTestMethod()
        {
            DataService ds = new DataService();
            double a = 2;
            double x = 6;
            double y = 9;
            var res = ds.FirstCalculate(a, x, y);
            double wait = -7.88;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void SecondTestMethod()
        {
            DataService ds = new DataService();
            double a = 2;
            double x = 6;
            double y = 9;
            var res = ds.SecondCalculate(a, x, y);
            double wait = 28.42;
            Assert.AreEqual(wait, res);
        }
    }
}
