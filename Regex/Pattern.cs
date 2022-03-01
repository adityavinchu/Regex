using System;
using System.Text.RegularExpressions;

namespace validation
{
    public class Pattern
    {
        public static string mobNumber = "^[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";
        public bool Validate(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber,mobNumber);
        }
    }
}