using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KupriyanovEA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 100;
            int result = ds.FahrenheitToСelsius(temp);
            int wait = 38;
            Assert.AreEqual(wait, result);
        }
    }
}
