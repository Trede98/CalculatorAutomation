using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorAutomation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calc c = new Calc();

            c.clickOne();
            Thread.Sleep(700);
            c.clickFive();
            Thread.Sleep(700);
            c.clickMinus();
            Thread.Sleep(700);
            c.clickFour();
            Thread.Sleep(700);
            c.clickEqual();
            Thread.Sleep(700);
            Assert.AreEqual(11, c.getResult());
            c.closeApp();

            c.openApp();
            c.clickThree();
            Thread.Sleep(700);
            c.clickZero();
            Thread.Sleep(700);
            c.clickMultiply();
            Thread.Sleep(700);
            c.clickOne();
            Thread.Sleep(700);
            c.clickZero();
            Thread.Sleep(700);
            c.clickEqual();
            Thread.Sleep(700);
            Assert.AreEqual(300, c.getResult());
            c.closeApp();
        }
    }
}
