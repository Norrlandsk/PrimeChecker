namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Utils
    {
        public static int ConfirmCorrectInput(int allowedRange)
        {
            int confirmedChoice;
            do
            {
                string menuChoiceString = Console.ReadLine();

                bool successfulConversion = Int32.TryParse(menuChoiceString, out confirmedChoice);

                if (successfulConversion && confirmedChoice <= allowedRange)
                {
                    break;
                }
                else if (menuChoiceString == "")
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input!");
                }
            } while (true);
            return confirmedChoice;
        }

        public static void ContinueAndClear()
        {
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
