using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            } 
        }

        private static void Run()
        {
            var zodiacSigns = new ZodiacSigns.ZodiacSigns();
            Console.WriteLine("Enter the date of birth in the format: DD / MM / YYYY");
            var dateOfBirth = GetData();
            Console.WriteLine(zodiacSigns.Run((int.Parse(dateOfBirth[0])), (int.Parse(dateOfBirth[1])), (int.Parse(dateOfBirth[2]))));
        }

        private static string[] GetData()
        {
            var dateofBirth = Console.ReadLine();

            if (string.IsNullOrEmpty(dateofBirth))
            {
                throw new FormatException("Invalid Date Of Birth");
            }

            var arrayDateOfBirth = dateofBirth.Split('/');
            return arrayDateOfBirth;
        }
    }

}
