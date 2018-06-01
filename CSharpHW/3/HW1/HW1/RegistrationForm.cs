using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HW1
{
    public class RegistrationForm
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthDate { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string AdditionalInfo { get; set; }

    }
}
