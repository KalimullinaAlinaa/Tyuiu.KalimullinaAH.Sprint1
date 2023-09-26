using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint1.Task4.V12.Lib;

namespace Tyuiu.KalimullinaAH.Sprint1.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.879;
            double y = 9.978;
            double wait = -0.041;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait, res);

        }
    }
}
