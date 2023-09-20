using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint1.Task1.V23.Lib;

namespace Tyuiu.KupriyanovEA.Sprint1.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double a = 4.0;
            var res = ds.Calculate(a, x);
            Assert.AreEqual(0.785, res);
        }
    }
}
