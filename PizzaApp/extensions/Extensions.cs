using System;
namespace PizzaApp.extensions
{
    public static class StringExtensions
    {
        public static string PremiereLettreMajuscule(this string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return str;
            }

            // MONTAGNARDE (str)

            string ret = str.ToLower();

            // montagnarde (ret)

            ret = ret.Substring(0, 1).ToUpper() + ret.Substring(1, ret.Length-1);
            // 0123456789
            // Montagnarde (ret)


            return ret;
        }
    }
}
