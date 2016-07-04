using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroshi.Entensions
{
    public static class StringExtensions
    {
        public static string AppendTest(this string text)
        {
            return string.Format("Test-{0}", text);
        }

        public static string Reverse(this string text)
        {
            if (text == null)
            {
                return null;
            }

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
