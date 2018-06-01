using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW1
{
    class RegistrationFormValidation
    {
        public static string NameValidation(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Is Null or WhiteSpace";
            }

            if (name.Length >= 255 || name.Length <= 0)
            {
                return "Length is not < 255 or = 0";
            }

            foreach (var i in name)
            {
                if (!char.IsLetter(i))
                {
                    return "This field should consists only from letters";
                }

            }

            return "This field is Valid";
        }

        public static string EmailValidation(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return "Is Null or WhiteSpace";
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(email) ? "Email is Valid" : "Email is InValid";
        }

        public static string AdditionalInfoValidation(string additionalInfo)
        {
            if (string.IsNullOrWhiteSpace(additionalInfo))
            {
                return "Is Null or WhiteSpace";
            }

            return additionalInfo.Length < 2000 ? "Additional Info is Valid" : "Additional Info is InValid";
        }

        public static string GenderValidation(string gender)
        {
            if (string.IsNullOrWhiteSpace(gender))
            {
                return "Is Null or WhiteSpace";
            }

            return gender.Equals("Male")
                   || gender.Equals("male")
                   || gender.Equals("Female")
                   || gender.Equals("female")
                ? "Gender is Valid"
                : "Gender is InValid";
        }

        public static string PhoneNumberValidation(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return "Is Null or WhiteSpace";
            }

            if (phoneNumber.Length != 12)
            {
                return "Phone Number should consists from 12 number";
            }

            foreach (var item in phoneNumber)
            {
                if (!char.IsDigit(item))
                {
                    return "PhoneNumber should consists only from numbers";
                }
            }

            return "PhoneNumber is Valid";
        }
    }
}
