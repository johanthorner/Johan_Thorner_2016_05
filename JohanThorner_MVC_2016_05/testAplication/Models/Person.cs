using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testAplication.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        [CheckNameAttribute]
        public string Name { get; set; }
    }

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