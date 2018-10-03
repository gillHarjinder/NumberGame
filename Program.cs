using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreedUser();



            while (true)
            {

                // Generate Random Number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);


                // Initializing the Guessing number variable

                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // Get user Number
                    string input = Console.ReadLine();

                    // Check the User input is only Number
                    if (!int.TryParse(input, out guess))
                    {
                        // call print color msg function
                        PrintColorMsg(ConsoleColor.Red, "Please enter actual number");
                        continue;
                    }

                    // Convert input string into int
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Tell USer its Wrong number
                        PrintColorMsg(ConsoleColor.DarkRed, "Wrong Number!! Please Try Again");

                    }
                }

                // Success Msg
                // Changing the text color
                PrintColorMsg(ConsoleColor.Yellow, "Coorect Number");

                // Ask if Play Again
       
                Console.WriteLine("Play Again? [ Y / N ]");

                // Getting the user Input
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                } else
                {
                    return;
                }
            }


        }


        static void GetAppInfo()
        {
            // Setting up the application variables
            string appName = " Guess The Number ";
            string appVersion = "1.0.0";
            string appAuthor = "Harjinder Gill";

            // Changing the text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Writintg the Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Getting text color
            Console.ResetColor();
        }

        static void PrintColorMsg(ConsoleColor color, string message)
        {
            // Changing the text color
            Console.ForegroundColor = color;

            // Tell USer its Wrong User Input
            Console.WriteLine(message);

            // Getting text color
            Console.ResetColor();

        }

        static void GreedUser()
        {
            // Ask Users name
            Console.WriteLine("What is Your name? ");

            // Getting the user Input
            string userInput = Console.ReadLine();

            Console.WriteLine("Hello {0} Let's Play a game ...", userInput);
        }
    }
}
