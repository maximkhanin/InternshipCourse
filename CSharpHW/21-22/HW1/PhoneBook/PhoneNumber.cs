﻿namespace HW1.PhoneBook
{
    class PhoneNumber
    {
        public long Number { get; }

        public PhoneNumber(long number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
