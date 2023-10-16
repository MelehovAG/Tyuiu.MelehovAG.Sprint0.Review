using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MelehovAG.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.MelehovAG.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int number1 = 5;
            int number2 = 6;
            int number3 = 7;

            int think = 90;
            int res = DataService.Calc(number1, number2, number3);
            Assert.AreEqual(think, res);
        }
    }
}
