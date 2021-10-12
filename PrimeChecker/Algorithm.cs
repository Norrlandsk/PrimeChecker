namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Algorithm
    {
        public static bool IsPrime(long candidate)
        {
            var limit = Math.Ceiling(Math.Sqrt(candidate));
            bool isPrime = true;
            //Console.WriteLine($"1. Räkna ut roten av {candidate} och få fram ett gränsvärde ({limit}).\n2. Dela {candidate} med alla heltal mellan 2-{limit}\n" +
            //        $"3. Om alla iterationer ger något annat än 0 i rest så är {candidate} ett primtal");
            //for (int i = 2; i <= limit; i += 1)
            //{
            //    Console.WriteLine("iter: " + i + " rest: " + candidate % i);
            //}
            //int.MaxValue=2147483647
            //2055446265
            if (candidate == 1) return isPrime = false;
            if (candidate == 2) return isPrime;
            if (candidate == 3) return isPrime;
            if (candidate == 5) return isPrime;
            if (candidate % 2 == 0 && candidate != 2) return isPrime = false;
            if (candidate % 3 == 0 && candidate != 3) return isPrime = false;
            if (candidate % 5 == 0 && candidate != 5) return isPrime = false;
            if (candidate % 7 == 0 && candidate != 7) return isPrime = false;
            if (candidate % 11 == 0 && candidate != 11) return isPrime = false;
            if (candidate % 13 == 0 && candidate != 13) return isPrime = false;
            if (candidate % 17 == 0 && candidate != 17) return isPrime = false;
            for (int i = 2; i <= limit; i += 1)
            {
                if (candidate % i == 0)
                {
                    isPrime = false;
                }

            }
            return isPrime;
        }
    }
}
