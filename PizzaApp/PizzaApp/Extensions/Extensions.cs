using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string str)
        {
            if(String.IsNullOrEmpty(str)) return str;
            string ret = str.ToLower();

            ret = ret.Substring(0, 1).ToUpper() + ret.Substring(1, ret.Length - 1);
            return ret;
        }
    }
}
