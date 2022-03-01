using System;
using System.Text.RegularExpressions;

namespace validation
{
    public class Pattern
    {
        public static string firstname = "^[A-Z]{1}[a-z,A-Z,0-9]{2,}$";
        public bool Validate(string firstname)
        {
            return Regex.IsMatch(firstname, firstname);
        }
    }
}