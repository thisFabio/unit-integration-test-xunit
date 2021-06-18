using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordValidatorLibrary
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            /*
             * The password length must be at least eight characters and a maximum of twenty characters
             * The password must contain one or more uppercase characters
             * The password must contain one or more lowercase characters
             * The password must contain one or more numeric values
             * The password must contain one or more special characters in the list @#!$%
             */
            Regex passwordPolicyExpression = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#!$%]).{8,20})");
            return passwordPolicyExpression.IsMatch(password);
        }
    }
}
