using System;
using System.Text.RegularExpressions;

namespace validation
{
    public class Pattern
    {
        public static string pswd = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
        public bool Validate(string password)
        {
            return Regex.IsMatch(password,pswd);
        }
    }
}