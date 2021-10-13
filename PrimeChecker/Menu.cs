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
                Console.WriteLine("Choose option \n");
                Console.WriteLine("[1] Check primality of number");
                Console.WriteLine("[2] Print Prime Number List");
                Console.WriteLine("[3] Find next prime number");
                Console.WriteLine("[4] Quit application");

                option = Utils.ConfirmCorrectInput(4);

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Data.currentCandidate=Validator.ValidateCandidate();
                        if (Data.currentCandidate > 0)
                        {
                            
                            if (Algorithm.IsPrime(Data.currentCandidate))
                            {
                                Console.Clear();
                                if (!Data.IsNumberInList(Data.currentCandidate))
                                {
                                    
                                    Console.WriteLine($"{Data.currentCandidate} is a prime number! \nIt is added to the Prime Number List.");
                                    Data.AddNumberToList(Data.currentCandidate);
                                    
                                }
                                else
                                {
                                    Console.WriteLine($"{Data.currentCandidate} is a prime number! \nIt is already present in the Prime Number List.");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"{Data.currentCandidate} is not a prime number.");
                            }
                            Utils.ContinueAndClear();
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Data.PrintList();
                        Utils.ContinueAndClear();
                        break;
                    case 3:
                        Console.Clear();
                        if (Data.PrimeNumberList.Count > 0)
                        {
                            
                            long previousLargestPrime = Data.PrimeNumberList.Last();
                            long currentLargestPrime = Algorithm.FindNextPrime(previousLargestPrime);
                            Console.WriteLine($"The previous largest prime is {previousLargestPrime}...");
                            Console.WriteLine($"Next prime number is {currentLargestPrime}.\nIt is added to the Prime Number List");
                            Data.AddNumberToList(currentLargestPrime);
                        }
                        else
                        {
                            Console.WriteLine("There appears to be no previous prime numbers in the Prime Number List");
                            
                        }
                        Utils.ContinueAndClear();
                        break;
                    case 4:
                        Console.Clear();
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
