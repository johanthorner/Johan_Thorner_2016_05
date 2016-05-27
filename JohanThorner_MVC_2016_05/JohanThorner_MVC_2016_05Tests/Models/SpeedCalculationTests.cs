using Microsoft.VisualStudio.TestTools.UnitTesting;
using JohanThorner_MVC_2016_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohanThorner_MVC_2016_05.Models.Tests
{
    [TestClass()]
    public class SpeedCalculationTests
    {
        [TestMethod()]
        public void GetCurrentSpeedTest_CalculationIsCorrect()
        {
           SpeedCalculation speed = new SpeedCalculation();
           var actual = speed.GetCurrentSpeed("100", "10");
           var expected = 10;
           Assert.AreEqual(expected,actual);

        }
        [TestMethod()]
        public void GetCurrentSpeedTest_ConvertCommas()
        {
            SpeedCalculation speed = new SpeedCalculation();
            var actual = speed.GetCurrentSpeed("100,0", "10,0");
            var expected = 10;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void GetCurrentSpeedTest_InputsAreDivideble()
        {
            SpeedCalculation speed = new SpeedCalculation();
            var actual = speed.GetCurrentSpeed("hundra", "10,0");
            

        }
        /*testa:
         Check FOr commas , Calculation is correct,  not dividable by zerro*/
    }
}