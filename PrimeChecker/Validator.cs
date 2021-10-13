namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// Validates correct data for algorithm.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Validates correct input for algorithm with Int64.Parse(). Catches exceptions and notifies user.
        /// User is prompted for input until all criteria are met, i.e. integers between 1 and int64.MaxValue.
        /// If invalid user input is received 5 times, the user is notified of criteria. Returns long candidate.
        /// </summary>
        /// <returns>long candidate</returns>
        public static long ValidateCandidate()
        {
            long candidate = 0;
            bool isValid = false;
            bool isExceptionTriggered = false;
            int tryCount = 0;
            long minVal = 1;

            while (!isValid)
            {
                Console.Clear();
                Console.Write("Enter a candidate (press Enter to go back to main menu): ");
                string candidateString = Console.ReadLine();

                if (candidateString == "")
                {
                    Console.Clear();
                    break;
                }

                try
                {
                    candidate = Int64.Parse(candidateString);
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input format!");
                    Thread.Sleep(1750);
                    Console.Clear();
                    isExceptionTriggered = true;
                }
                catch (ArgumentNullException)
                {
                    Console.Clear();
                    Console.WriteLine("Input was null!");
                    Thread.Sleep(1750);
                    Console.Clear();
                    isExceptionTriggered = true;
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("Candidate was out of range!");
                    Thread.Sleep(1750);
                    Console.Clear();
                    isExceptionTriggered = true;
                }

                if (candidate < minVal && !isExceptionTriggered)
                {
                    Console.Clear();
                    Console.WriteLine("Candidate must be above zero!");
                    Thread.Sleep(1750);
                    Console.Clear();
                }
                else if (candidate >= minVal)
                {
                    isValid = true;
                }

                isExceptionTriggered = false;
                tryCount++;
                if (tryCount >= 5)
                {
                    Console.Clear();
                    Console.WriteLine("Input restrictions:\n");
                    Console.WriteLine("Can only contain digits");
                    Console.WriteLine("Must be above zero");
                    Console.WriteLine("Must be below 9223372036854775808");
                    Console.WriteLine("Cannot contain decimals\n");
                    Utils.ContinueAndClear();
                    tryCount = 0;
                }
            }
            return candidate;
        }
    }
}