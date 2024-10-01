using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pet_Amigos.Classes.Utils
{
    internal static class Validator
    {
        static string patron = @"^[a-zA-Z\s]+$";
        static string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";


        public static bool isValidText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return !Regex.IsMatch(text, patron);
            }
            else return false;
        }

        public static bool isValidNum(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return int.TryParse(text, out int num);
            }
            else return false;
        }

        public static bool isValidEmail(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return !Regex.IsMatch(text, emailPattern);
            }
            else return false;
        }
    }
}
