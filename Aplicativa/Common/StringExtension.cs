using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicativa.Common
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return str == null || str == "";
        }

        public static bool IsLessThanZero(this int number)
        {
            return number < 0;
        }
    }
}
