﻿namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Algorithm
    {
        public static long currentPrime;
        public static List<long> PrimeNumberList=new List<long>();
        public static bool IsPrime(long candidate)
        {
            
            bool isPrime = true;

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
            var limit = Math.Ceiling(Math.Sqrt(candidate));
            for (int i = 5; i <= limit; i += 2)
            {
                if (candidate % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                currentPrime = candidate;
            }
            return isPrime;
        }

        public static void AddNumberToList(long candidate)
        {
            if (!PrimeNumberList.Contains(candidate))
            {
                PrimeNumberList.Add(candidate);
            }
            PrimeNumberList.Sort();
        }

        public static void PrintList()
        {
            if (PrimeNumberList.Count > 0)
            {
                Console.WriteLine("Here are the prime numbers found so far:\n");
                foreach (long prime in PrimeNumberList)
                {
                    Console.WriteLine(prime + "\n");
                }
            }
            else
            {
                Console.WriteLine("The Prime Number List is empty");
            }
            
        }

        public static long FindNextPrime(long previousLargestPrime)
        {
            bool found = false;
            long nextPrime=0;

            while (!found)
            {
                previousLargestPrime++;
                if (IsPrime(previousLargestPrime))
                {
                    nextPrime = currentPrime;
                    found = true;
                }

            }
            return nextPrime;
        }
    }
}
