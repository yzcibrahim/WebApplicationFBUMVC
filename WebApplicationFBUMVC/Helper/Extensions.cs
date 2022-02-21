using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFBUMVC.Helper
{
    public static class Extensions
    {
        public static string ToPascal(this string strInput,string suffix)
        {
            string result = "";

            bool flag = false;
            for (int i = 0; i < strInput.Length; i++)
            {
                if (i == 0 || flag)
                {
                    flag = false;
                    result += strInput[i].ToString().ToUpper();
                }
                else
                {
                    result += strInput[i].ToString().ToLower();
                }
                if (strInput[i].ToString() == " ")
                {
                    flag = true;
                }
            }
            return result+ suffix;
        }
    }
}
