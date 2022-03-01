using System;
using System.Text.RegularExpressions;

namespace validation
{
    public class Pattern
    {
        public static string email = "^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public bool Validate(string Email)
        {
            return Regex.IsMatch(Email, email);
        }
    }
}