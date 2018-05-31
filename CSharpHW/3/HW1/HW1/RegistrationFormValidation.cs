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
        public static bool isValid(RegistrationForm registrationForm)
        {
            return NameValidation(registrationForm.FirstName);
        }

        private static bool NameValidation(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            if (name.Length >= 255 || name.Length <= 0) return false;

            foreach (var i in name)
            {
                if (!char.IsLetter(i))
                {
                    return false;
                }

            }

            return true;
        }
    }
}
