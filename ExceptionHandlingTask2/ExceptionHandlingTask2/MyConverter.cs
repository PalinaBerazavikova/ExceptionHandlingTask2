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
        public static int MyTryParse(string str)
        {
            int number=0;
            str = str.Trim();
            Regex rgx = new Regex(@"^[+-]?\d+$");
            if (rgx.IsMatch(str))
            {
                return number = MyConverter.ConvertToInt(str);
            }
            return number;

        }
        private static int ConvertToInt(string str)
        {
            int count = str.Length;
            int number = 0;
            foreach(char digit in str)
            {
                number += (int)char.GetNumericValue(digit) * (int)Math.Pow(10, count);
                count--;
            }
            return number;
        }
    }
}
