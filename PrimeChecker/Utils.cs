namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// Helper methods.
    /// </summary>
    internal static class Utils
    {
        /// <summary>
        /// Takes int allowedRange as argument, which corresponds to the number of choices in menu.
        /// Confirms that user input is valid, i.e. an integer within range. Will ask for input until valid. Returns confirmedChoice.
        /// </summary>
        /// <param name="allowedRange"></param>
        /// <returns>int confirmedChoice</returns>
        public static int ConfirmCorrectInput(int allowedRange)
        {
            int confirmedChoice;
            do
            {
                string menuChoiceString = Console.ReadLine();

                bool successfulConversion = Int32.TryParse(menuChoiceString, out confirmedChoice);

                if (successfulConversion && confirmedChoice <= allowedRange && confirmedChoice > 0)
                {
                    break;
                }
                else if (menuChoiceString == "")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write("Invalid input!");
                    Thread.Sleep(1050);
                    Console.Clear();
                    break;
                }
            } while (true);
            return confirmedChoice;
        }

        /// <summary>
        /// Gives space between changes in console GUI.
        /// </summary>
        public static void ContinueAndClear()
        {
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}