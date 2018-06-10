using System;

namespace HW1
{
    class Lottery
    {
        public readonly Number[] Numbers;

        /// <summary>
        /// Write six numbers from 0 to 9
        /// </summary>
        public Lottery()
        {
            Numbers = new Number[6];
   
            var random = new Random();
            for (var i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = new Number(random.Next(0, 9));
            }
        }

        public Number[] GetNumber()
        {
            return Numbers;
        }

        public bool WinCheck(Number[] numbers)
        {
            for (var i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i]!=numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int Length => Numbers.Length;

        public Number this[int index]
        {
            get => Numbers[index];
            set => Numbers[index] = value;
        }
    }
}
