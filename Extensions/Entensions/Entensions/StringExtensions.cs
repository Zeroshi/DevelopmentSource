using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            var array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        public static string RandomOutput(this string text)
        {
            if (text == null)
            {
                return null;
            }

            var textArray = text.ToCharArray();
            var usedIndexes = new List<int>();
            var randomText = string.Empty;
            var random = new Random();
            var builder = new StringBuilder();

            builder.Append(randomText);

            do
            {
                var randomIndex = random.Next(textArray.Count());

                if (!usedIndexes.Contains(randomIndex))
                {
                    builder.Append(textArray[randomIndex]);
                    usedIndexes.Add(randomIndex);
                }

            } while (randomText.Length < text.Length);
            randomText = builder.ToString();

            return randomText;
        }

        public static string RemoveNonNumerics(this string text)
        {
            return Regex.Replace(text, @"\D", "");
        }

        public static string RemoveSpecialCharacters(this string text)
        {
            return Regex.Replace(text, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        public static bool ContainsNumerics(this string text)
        {
            return text.Any(char.IsDigit);
        }

        public static bool ContainsAlphaNumbericCharacters(this string text)
        {
            return text.Any(char.IsLetterOrDigit);
        }

        public static bool ContainsAlphaCharacters(this string text)
        {
            return text.Any(char.IsLetter);
        }

        public static string AddSpacesToCamelCase(this string text)
        {
            var updatedString = string.Empty;

            //insert spaces before each capitolized character
            if (!string.IsNullOrEmpty(text) && text.Length >= 0)
            {
                foreach (var character in text)
                {
                    if (character.ToString().Any(char.IsUpper))
                    {
                        updatedString += string.Format(@"{0}{1}", " ", character);
                    }
                    else
                    {
                        updatedString += character;
                    }
                }
            }

            //Capitolize the initial charater in the new string 
            if (updatedString.Length > 0)
            {
                var startUpper = updatedString[0].ToString().ToUpper();
                updatedString = updatedString.Remove(0, 1);
                updatedString = updatedString.Insert(0, startUpper);                
            }

            return updatedString;
        }
    }
}
