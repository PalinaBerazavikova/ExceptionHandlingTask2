using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionHandlingTask2
{
    public static class MyConverter
    {
        public static int MyParse(string str)
        {
            int number = 0;
            str = str.Trim();
            if (str.Contains("."))
            {
                str = str.Remove(str.IndexOf("."));
            }
            if (str.Contains(","))
            {
                str = str.Remove(str.IndexOf(","));
            }
            char sym = '+';
            Regex rgx = new Regex(@"^[+-]?\d+$");
            if (rgx.IsMatch(str))
            {
                if (!char.IsDigit(str.First()))
                {
                    sym = str.First();
                    number = ConvertToInt(str.Substring(1, str.Length - 1));
                    return sym == '-' ? 0 - number : number;
                }
                else
                {
                    return number = MyConverter.ConvertToInt(str);
                }
            }else
            {
                throw new WrongFormatException("Value is not valid");
            }
            return number;
        }
        private static int ConvertToInt(string str)
        {
            int count = str.Length - 1;
            int number = 0;
            checked
            {
                foreach (char digit in str)
                {
                    number += (int)char.GetNumericValue(digit) * (int)Math.Pow(10, count);
                    count--;
                }
            }
            return number;
        }
    }
}
