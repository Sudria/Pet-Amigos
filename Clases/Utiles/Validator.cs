using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Validator
{
    string patron = @"^[a-zA-Z\s]+$";

    public static bool textValidator(string text)
    {
        return Regex.IsMatch();
    }

    public static bool numValidator(string text)
    {
        return !int.TryParse(text, out var num);
    }
}
