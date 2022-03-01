using System;
using System.Text.RegularExpressions;

namespace validation
{
    public class Pattern
    {
        public static string pswd = "^(?=.*[a-z])(?=.*[A-Z])[a-zA-Z]{8,}$";
        public bool Validate(string password)
        {
            return Regex.IsMatch(password,pswd);
        }
    }
}