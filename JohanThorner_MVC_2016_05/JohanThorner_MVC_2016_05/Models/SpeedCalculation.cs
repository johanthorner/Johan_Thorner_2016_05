using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JohanThorner_MVC_2016_05.Models
{
    public class SpeedCalculation
    {
        public decimal GetCurrentSpeed(string distanceConveredInput, string timeInput)
        {
            decimal distance, time;
            bool distanceIsValid = decimal.TryParse(distanceConveredInput, out distance);
            bool timeIsValid = decimal.TryParse(timeInput, out time);

            if (distanceIsValid && timeIsValid)
            {
                return distance/time;
            }
            throw new DivideByZeroException();
        }
    }
}