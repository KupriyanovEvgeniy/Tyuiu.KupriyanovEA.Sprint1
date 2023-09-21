using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint1.Task2.V13.Lib;

namespace Tyuiu.KupriyanovEA.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 2;
            var res = ds.ConvertMilesToKm(value);
            Assert.AreEqual(3.22, res);
        }
    }
}
