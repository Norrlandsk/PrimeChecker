namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Menu
    {
        public static void MainMenu()
        {
            bool isRunning = true;
            int option;
            

            while (isRunning)
            {
                long currentCandidate = 0;
                Console.WriteLine("Choose option \n");
                Console.WriteLine("[1] Check primality of number");
                Console.WriteLine("[2] Print Prime Number List");
                Console.WriteLine("[3] Find next prime number");
                Console.WriteLine("[4] Quit application");

                option = Utils.ConfirmCorrectInput(4);

                switch (option)
                {
                    case 1:
                        currentCandidate=Validator.ValidateCandidate();
                        if (currentCandidate > 0)
                        {
                            if(Algorithm.IsPrime(currentCandidate))
                            {
                                Console.Clear();
                                Console.WriteLine($"{currentCandidate} is a prime number! \nIt is added to the Prime Number List.");
                                Algorithm.AddNumberToList(currentCandidate);
                                Utils.ContinueAndClear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"{currentCandidate} is not a prime number.");
                                Utils.ContinueAndClear();
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Algorithm.PrintList();
                        Utils.ContinueAndClear();
                        break;
                    case 3:
                        if (Algorithm.PrimeNumberList.Count > 0)
                        {
                            Console.Clear();
                            long previousLargestPrime = Algorithm.PrimeNumberList.Last();
                            long currentLargestPrime = Algorithm.FindNextPrime(previousLargestPrime);
                            Console.WriteLine($"The previous largest prime is {previousLargestPrime}...");
                            Console.WriteLine($"Next prime number is {currentLargestPrime}.\nIt is added to the Prime Number List");
                            Algorithm.AddNumberToList(currentLargestPrime);
                            Utils.ContinueAndClear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("There appears to be no previous prime numbers in the Prime Number List");
                            Utils.ContinueAndClear();
                        }
                        

                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Quitting application...");
                        break;
                    default:
                        break;
                }

                


              
            }

        }
    }
}
