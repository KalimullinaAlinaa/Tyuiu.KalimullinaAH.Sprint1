using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint1.Task3.V13.Lib;
namespace Tyuiu.KalimullinaAH.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()

        {
            DataService ds = new DataService();
            double num = 123;
            double wait = 6;
            var res = ds.Calculate(num);
            Assert.AreEqual(wait, res);


        }
    }
}
