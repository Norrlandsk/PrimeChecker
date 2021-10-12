namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;

    public static class Validator
    {
        public static long ValidateCandidate()
        {
            long candidate = 0;
            bool isValid = false;
            int tryCount = 0;
            long minVal = 1;
            long maxVal = long.MaxValue;


            while (!isValid)
            {
                Console.Clear();
                Console.Write("Enter a candidate: ");
                string candidateString = Console.ReadLine();

                    try
                    {
                        candidate = Int64.Parse(candidateString);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect input format!");
                        Thread.Sleep(1750);
                        Console.Clear();
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Input was null!");
                        Thread.Sleep(1750);
                        Console.Clear();
                    }
                    catch (OverflowException)
                    {
                            Console.WriteLine("Candidate must be below 9223372036854775808");
                            Thread.Sleep(1750);
                            Console.Clear();
                    }

                if (candidate < minVal)
                {
                    Console.WriteLine("Candidate must be above zero");
                    Thread.Sleep(1750);
                    Console.Clear();
                }

                tryCount++;
                if (tryCount >= 5)
                {
                    Console.Clear();
                    Console.WriteLine("Input restrictions:\n");
                    Console.WriteLine("Can only be digits");
                    Console.WriteLine("Must be positive");
                    Console.WriteLine("Must be below 9223372036854775808");
                    Console.WriteLine("Cannot contain decimals\n");
                    Console.WriteLine("Please try again");
                    Console.ReadLine();
                    Console.Clear();
                    tryCount = 0;
                }
                    if (candidate > 0)
                    {
                        isValid = true;
                    }
                
            }
            return candidate;
        }

    }
}
