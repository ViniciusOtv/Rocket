using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rocket.Extensions
{
    public static class StringExtensions
    {
        public static bool ValidateDocument(this string Document)
        {
            Document = Document.RemoveFormatting();

            if (Document.Any(ch => !char.IsNumber(ch)))
            {
                return false;
            }


            if (Document.Length != 11)
                return false;

            var total = 0;
            var mod = 0;
            for (var i = 0; i < 9; i++)
            {
                var current = Document[i];
                total += int.Parse(current.ToString()) * (i + 1);
            }
            mod = total % 11;

            if (mod == 10) mod = 0;

            if (mod.ToString() != Document[9].ToString())
                return false;
            total = 0;
            for (var i = 0; i < 10; i++)
            {
                var current = Document[i];
                total += int.Parse(current.ToString()) * (i);
            }
            mod = total % 11;

            if (mod == 10) mod = 0;

            return mod.ToString() == Document[10].ToString();
        }

        public static string RemoveFormatting(this string input)
        {
            return Regex.Replace(input, @"[A-Za-z./-]", "");
        }
        public static string RemoveSpecialCharacters(this string input)
        {
            return Regex.Replace(input, "[^0-9a-zA-Z]+", "");
        }
    }
}