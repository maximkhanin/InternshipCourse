using System;
using System.Collections.Generic;
using System.Linq;

namespace HW1.Logger
{
    class Logger: List<Log>
    {
        public void MostFrequentlyReceivingNumbers(int count)
        {
            var result = this.GroupBy(x => x.Receiver).OrderByDescending(x => x.Count()).Take(count);

            foreach (var item in result)
            {
                var rate = 0.0;
                foreach (var t in item)
                {
                    rate += t.Rate;
                }

                Console.WriteLine("{0} - {1}", item.Key.Number, rate);
            }
        }

        public void MostFrequentlySendingNumbers(int count)
        {
            var result = this.GroupBy(x => x.Sender).OrderByDescending(x => x.Count()).Take(count);

            foreach (var item in result)
            {
                var rate = 0.0;
                foreach (var t in item)
                {
                    rate += t.Rate;
                }

                Console.WriteLine("{0} - {1}", item.Key.Number, rate);
            }
        }
    }
}
