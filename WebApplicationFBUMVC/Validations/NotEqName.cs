using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFBUMVC.Models;

namespace WebApplicationFBUMVC.Validations
{
    public class NotEqName : ValidationAttribute
    {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
   // var surname = value.ToString();
    var person = (PersonViewModel)validationContext.ObjectInstance;
  //  var name = person.Name;

    if (person.Name==person.Surname)
    {
        return new ValidationResult("name surname can not be equal");
    }

    return ValidationResult.Success;
    }

        
    }
}
