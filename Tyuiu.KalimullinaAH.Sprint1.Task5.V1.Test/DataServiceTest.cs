using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint1.Task5.V1.Lib;
namespace Tyuiu.KalimullinaAH.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 8;
            double x2 = 2;
            double y1 = 10;
            double y2 = 15;
            double res = ds.DistanceBetweenDots(x1,y1,x2,y2);
            double wait = 7;
            

            Assert.AreEqual(wait, res);

        }
    }
}
