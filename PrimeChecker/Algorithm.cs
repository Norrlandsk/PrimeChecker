namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Algorithm methods.
    /// </summary>
    public static class Algorithm
    {
        /// <summary>
        /// Takes long candidate as argument. Returns true if candidate is evaluated as prime number. Algorithm is based on trial division.
        ///
        /// PHASE ONE evaluates if candidate is one the first 3 prime numbers in order for index i in for loop to be able to begin with an odd number.
        /// Doing this enables the algorithm to skip evaluation of candidate%[even number]==0 by not iterating over even numbers,
        /// i.e. the loop starts at 5 and iterates over every other number until limit. Doing this decimates the number of iterations in PHASE THREE by half.
        ///
        /// PHASE TWO evaluates if candidate is even, or if divisible without remainder with the first 6 prime numbers. This phase is done merely to, if possible,
        /// avoid stepping to PHASE THREE altogether, since PHASE THREE is the most time consuming phase, especially for large candidates.
        ///
        /// PHASE THREE calculates square root of candidate to use as limit in for loop. The for loop evaluates if candidate%[odd number]==0 until limit.
        /// If no iterations between 5 and every other number until limit have no remainder, the candidate is evaluated as a prime number.
        ///
        /// FINAL PHASE sets Data.currentPrime to candidate and returns bool isPrime.
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns>bool isPrime</returns>
        public static bool IsPrime(long candidate)
        {
            Console.Clear();
            Console.WriteLine("Calculating. Please wait...");
            bool isPrime = true;

            //PHASE ONE
            if (candidate == 1) return isPrime = false;
            if (candidate == 2) return isPrime;
            if (candidate == 3) return isPrime;
            if (candidate == 5) return isPrime;

            //PHASE TWO
            if (candidate % 2 == 0 && candidate != 2) return isPrime = false;
            if (candidate % 3 == 0 && candidate != 3) return isPrime = false;
            if (candidate % 5 == 0 && candidate != 5) return isPrime = false;
            if (candidate % 7 == 0 && candidate != 7) return isPrime = false;
            if (candidate % 11 == 0 && candidate != 11) return isPrime = false;
            if (candidate % 13 == 0 && candidate != 13) return isPrime = false;
            if (candidate % 17 == 0 && candidate != 17) return isPrime = false;

            //PHASE THREE
            var limit = Math.Ceiling(Math.Sqrt(candidate));
            for (long i = 5; i <= limit; i += 2)
            {
                if (candidate % i == 0)
                {
                    isPrime = false;
                }
            }

            //FINAL PHASE
            if (isPrime)
            {
                Data.currentPrime = candidate;
            }
            return isPrime;
        }

        /// <summary>
        /// Takes long previousLargestPrime as argument. While bool found evaluates to false, previousLargestPrime is iterated and sent to method IsPrime.
        /// This is done until IsPrime(previousLargestPrime++) returns true. When this happens, the while loop breaks and long nextPrime is set to Data.currentPrime
        /// and nextPrime is sent back.
        /// </summary>
        /// <param name="previousLargestPrime"></param>
        /// <returns>long nextPrime</returns>
        public static long FindNextPrime(long previousLargestPrime)
        {
            bool found = false;
            long nextPrime = 0;

            while (!found)
            {
                previousLargestPrime++;
                if (IsPrime(previousLargestPrime))
                {
                    nextPrime = Data.currentPrime;
                    found = true;
                }
            }
            return nextPrime;
        }
    }
}