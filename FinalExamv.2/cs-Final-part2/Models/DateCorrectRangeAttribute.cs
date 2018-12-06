using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cs_Final_part2.Models
{
    public class DateCorrectRangeAttribute : ValidationAttribute
    {
        public bool ValidateBirthDate { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = validationContext.ObjectInstance as Astronaut;

            if(model != null)
            {
                if(model.Birthday > DateTime.Now.Date)
                {
                    return new ValidationResult(string.Empty);
                }
            }

            return ValidationResult.Success;
        }
    }
}