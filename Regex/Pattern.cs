using System;
using System.Text.RegularExpressions;

namespace validation
{
    public class Pattern
    {
        public static string pswd = "^[a-zA-Z0-9]{8,}$";
        public bool Validate(string password)
        {
            return Regex.IsMatch(password,pswd);
        }
    }
}