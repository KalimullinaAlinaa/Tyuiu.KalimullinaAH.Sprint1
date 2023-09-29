using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint1.Task7.V11.Lib;

namespace Tyuiu.KalimullinaAH.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 7;
            double wait = 5.591;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait, res);

        }
    }
}
