using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Validation
{
    public class isPositiveAttribute : ValidationAttribute
    {
        public isPositiveAttribute()
        {
        }
        public string GetErrorMessage() => $"Please only enter positive integers between 0 to 9999.";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int time = Convert.ToInt32(value);

            if (time < 0 || time > 2000000000)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
    }
}
