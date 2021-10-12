namespace PrimeChecker
{
    using System;
    using System.Collections.Generic;
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
                Console.WriteLine("[2] Print all found prime numbers");
                Console.WriteLine("[3] Find next prime number");
                Console.WriteLine("[4] Quit application");

                option = Utils.ConfirmCorrectInput(4);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Numret är "+ Validator.ValidateCandidate());
                        ;
                        break;
                    case 2:
                        break;
                    case 3:
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
