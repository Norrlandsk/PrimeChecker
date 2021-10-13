namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Contains and handles all the various forms of data used in the application.
    /// </summary>
    public static class Data
    {
        public static long currentCandidate;
        public static long currentPrime;
        public static List<long> PrimeNumberList = new List<long>();

        /// <summary>
        /// Adds data to data structure if not already present, and sorts data structure by ascending order.
        /// </summary>
        /// <param name="candidate"></param>
        public static void AddNumberToList(long candidate)
        {
            if (!IsNumberInList(candidate))
            {
                Data.PrimeNumberList.Add(candidate);
            }
            Data.PrimeNumberList.Sort();
        }

        /// <summary>
        /// Sends all elements in data structure to the console. If no objects are present, the user is notified.
        /// </summary>
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

        /// <summary>
        /// Returns true if data structure contains an element with the same value as currentCandidate.
        /// </summary>
        /// <param name="currentCandidate"></param>
        /// <returns>bool isNumberInList</returns>
        public static bool IsNumberInList(long currentCandidate)
        {
            bool isNumberInList = false;

            if (Data.PrimeNumberList.Contains(currentCandidate))
            {
                isNumberInList = true;
            }

            return isNumberInList;
        }
    }
}