using System;
using System.Text.RegularExpressions;

namespace validation
{
    public class Pattern
    {
        public static string email = "^[a-z]{1,}([.#$^_-][a-z0-9]+)?[@]{1}[a-z]{2,}[.][a-z]{2,3}([.][a-z]{2})?$";
        public bool Validate(string Email)
        {
            return Regex.IsMatch(Email, email);
        }
    }
}
