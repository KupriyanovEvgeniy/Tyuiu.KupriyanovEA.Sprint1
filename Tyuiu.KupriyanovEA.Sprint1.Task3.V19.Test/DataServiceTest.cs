using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.KupriyanovEA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 3;
            double y2 = 3;
            bool wait = true;
            var res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.AreEqual(wait, res);
        }
    }
}
