using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BlazorConference.Utils.Validations
{
    public class ValidExpirationAttribute : ValidationAttribute
    {

        public string OtherProperty { get; set; }
        public ValidExpirationAttribute(string otherProperty)
        {
            OtherProperty = otherProperty;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(!(value is int year))
            {
                return new ValidationResult("incorrect month or year");
            }
            PropertyInfo otherPropertyInfo = validationContext.ObjectType.GetProperty(OtherProperty);
            if (otherPropertyInfo == null)
            {
                return new ValidationResult("incorrect month or year");
            }

            object monthObj = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);

            if(!int.TryParse(monthObj?.ToString(), out int month))
            {
                return new ValidationResult("incorrect month or year");
            }


            var setDate = (new DateTime(year, month, 1)).AddMonths(1).AddDays(-1);

            if (setDate < DateTime.Today)
            {
                return new ValidationResult("incorrect month or year");
            }
            return null;

        }
    }
}
