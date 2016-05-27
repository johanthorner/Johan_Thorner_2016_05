using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Antlr.Runtime.Tree;

namespace JohanThorner_MVC_2016_05.Models
{
    public class CheckNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            var toCheck = value.ToString().ToLower();
            int digits;
            string[] del = toCheck.Split('-');
            bool endOfStringIsDigits = int.TryParse(del[1], out digits);
            return toCheck.StartsWith("p") && toCheck[1].Equals('-') && endOfStringIsDigits;
        }

        public override string FormatErrorMessage(string name)
        {
            return "följ formatet: p-123 ";
        }
    }
}