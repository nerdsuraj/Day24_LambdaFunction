using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day23_LambdaFunction
{
    public class MakingFromPattern
    {
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{3,}$";
        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
        }

        public static string REGEX_LASTNAME = "^[A-Z][a-z]{3,}$";
        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAME);
        }
        public static string REGEX_EMAIL = "^[0-9a-zA-Z]+([+#%&_.-][a-zA-Z0-9]+)*[@][0-9]?[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public static string REGEX_PHONENO = "^[1-9]{2}[ ][6-9][0-9]{9}$";
        public bool validatePhoneNo(string phoneno)
        {
            return Regex.IsMatch(phoneno, REGEX_PHONENO);
        }
        public static string REGEX_PASSWORD = "^[A-Z][A-Za-z0-9@#$&]{8,}$";
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }

    }
}
