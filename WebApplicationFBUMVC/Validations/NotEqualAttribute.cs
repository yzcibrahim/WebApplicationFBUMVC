using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFBUMVC.Validations
{
    public class NotEqualAttribute: ValidationAttribute
    {
        public string kim="talha";
        public override bool IsValid(object value)
        {
            //if (!base.IsValid(value))
            //    return false;
            if (value == null || value.ToString() == string.Empty)
            {
                ErrorMessage = "zorunlu!";
                return false;
            }
            if(value.ToString().ToUpper()== kim.ToUpper())
            {
                ErrorMessage = $"{kim} giremez";
                return false;
            }

            return true;
        }
    }
}
