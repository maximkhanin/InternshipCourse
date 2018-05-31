using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var registrationForm = new RegistrationForm {FirstName = "Maxim"};
            Console.WriteLine(registrationForm.FirstName);
            Validate(registrationForm);

        }
        private static void Validate(RegistrationForm registrationForm)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(registrationForm);
            if (!Validator.TryValidateObject(registrationForm, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("User '{0} {1}' is Valid", registrationForm.FirstName, registrationForm.LastName);
            }
        }
    }
}
