using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint1.Task4.V3.Lib;

namespace Tyuiu.KupriyanovEA.Sprint1.Task4.V3.Lib.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 2.449;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
