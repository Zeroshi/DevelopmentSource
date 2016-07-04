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
            if (text == null)
            {
                return null;
            }

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

        public static string RandomOutput(this string text)
        {
            if (text == null)
            {
                return null;
            }

            char[] textArray = text.ToCharArray();
            var usedIndexes = new List<int>();
            var randomText = string.Empty;
            var random = new Random();

            do
            {
                var randomIndex = random.Next(textArray.Count());

                if (!usedIndexes.Contains(randomIndex))
                {
                    randomText += textArray[randomIndex];
                    usedIndexes.Add(randomIndex);
                }

            } while (randomText.Length < text.Length);

            return randomText;
        }
    }
}
