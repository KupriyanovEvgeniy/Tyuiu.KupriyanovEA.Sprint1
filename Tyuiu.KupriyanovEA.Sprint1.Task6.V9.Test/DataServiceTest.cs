using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint1.Task6.V9.Lib;

namespace Tyuiu.KupriyanovEA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string value = "понял";
            string res = ds.MoveLetterToStart(value);
            string wait = "лпоня";
            Assert.AreEqual(wait, res);
        }
    }
}
