using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFBUMVC.Validations
{
    public class PalindromAttribute : ValidationAttribute
    {
        
        public override bool IsValid(object value)
        {
            if(value==null)
            { 
                return false;
            }

            string deger = value.ToString();
            string ters = "";
            
            for(int i=0;i<deger.Length;i++)
            {
                ters = deger[i].ToString() + ters;
            }
            if(ters!=deger)
            {
                ErrorMessage = "value must be polindrom";
                return false;
            }

            return true;
        }
    }
}
