using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint1.Task2.V21.Lib;

namespace Tyuiu.KalimullinaAH.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressiom()
        {

            DataService ds = new DataService();
            int a = 2;
            int b = 3;
            var res = ds.CalculateRectangleSquare(a, b);
            Assert.AreEqual(6, res);
        }
    }
}
