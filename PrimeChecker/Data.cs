namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Data
    {
        public static long currentCandidate;
        public static long currentPrime;
        public static List<long> PrimeNumberList = new List<long>();

        public static void AddNumberToList(long candidate)
        {
            if (!IsNumberInList(candidate))
            {
                Data.PrimeNumberList.Add(candidate);
            }
            Data.PrimeNumberList.Sort();
        }

        public static void PrintList()
        {
            if (Data.PrimeNumberList.Count > 0)
            {
                Console.WriteLine("Here are the prime numbers found so far:\n");
                foreach (long prime in Data.PrimeNumberList)
                {
                    Console.WriteLine(prime + "\n");
                }
            }
            else
            {
                Console.WriteLine("The Prime Number List is empty");
            }
        }

        public static bool IsNumberInList(long currentCandidate)
        {
            bool isNumberInList=false;

            if (Data.PrimeNumberList.Contains(currentCandidate))
            {
                isNumberInList = true;
            }

                return isNumberInList;
        }
    }
}
