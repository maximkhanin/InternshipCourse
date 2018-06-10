using System;
using System.Text.RegularExpressions;

namespace HW1
{
    class Numbers
    {
        private readonly Number[] _numbers;

        /// <summary>
        /// Write six numbers from 0 to 9
        /// </summary>
        public Numbers()
        {
            _numbers = new Number[6];
            Console.WriteLine("Input six numbers");
            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] = Validate(Console.ReadLine());
            }
        }

        public Number[] GetNumber()
        {
            return _numbers;
        }

        public Number Validate(string value)
        {
            var regex = new Regex("[^0-9]+");
           
            if (value.Length==1 && !regex.IsMatch(value))
            {
                return new Number(int.Parse(value));
            }

            throw new FormatException();
        }

        public int Length => _numbers.Length;

        public Number this[int index]
        {
            get => _numbers[index];
            set => _numbers[index] = value;
        }
    }
}
