using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("This is a random number guessing game. You will " +
                "provide a max number which then you will have to input another " +
                "number between 1 and the max number you input.");

            Console.WriteLine("press 'return' to continue...");
            Console.ReadLine();

            int secretNumber = 0;
            int userGuess = 0;

            int max = GetIntegerFromUser("Type a number to set as your max number. " +
                        "The larger the harder the guess will be.");

            Random rnd = new Random();

            secretNumber = rnd.Next(1, max + 1);

            var timesGuessed = 0;

            do
            {

                Console.WriteLine("Input your guess and press 'return'");
                userGuess = int.Parse(Console.ReadLine());

                Console.WriteLine($"You guessed {userGuess}");

                if (secretNumber > userGuess)
                {
                    timesGuessed++;

                    if (timesGuessed == 1)
                    {
                        Console.WriteLine($"Your guess is too low. You have guessed {timesGuessed} time so far.");
                    }
                    else
                    {
                        Console.WriteLine($"Your guess is too low. You have guessed {timesGuessed} times so far.");
                    }
                    
                }
                else if (secretNumber < userGuess)
                {
                    timesGuessed++;
                    if (timesGuessed == 1)
                    {
                        Console.WriteLine($"Your guess is too high. You have guessed {timesGuessed} time so far.");
                    }
                    else
                    {
                        Console.WriteLine($"Your guess is too high. You have guessed {timesGuessed} times so far.");
                    }
                }

            } while (secretNumber != userGuess);

            if (secretNumber == userGuess)
            {
                Console.WriteLine("You guessed correctly! Congrats!");
            }

        }

        static int GetIntegerFromUser(string question)

        {
            int integerFromUser;

            bool success;

            do

            {
                Console.WriteLine(question);

                string userResponse = Console.ReadLine();

                success = int.TryParse(userResponse, out integerFromUser);

            } while (success == false);

            return integerFromUser;
        }

    }
}
