using P4C1.Interfaces;

namespace P4C1.Services
{
    public class NumberGuessing : IApplication
    {
        public void Run()
        {
            try
            {
                Random random = new Random();
                Console.WriteLine("Welcome to the Number Guessing game...");
                Console.Write("Please select a difficulty level (1: EASY, 2: MEDIUM, 3: HARD): ");
                int level = Convert.ToInt32(Console.ReadLine());

                int maxNumber = level switch
                {
                    1 => 10,
                    2 => 50,
                    3 => 100,
                    _ => throw new InvalidOperationException("Invalid difficulty level.")
                };

                int targetNumber = random.Next(1, maxNumber + 1);
                int guess = -1;
                int attempts = 10;

                while (attempts > 0 && guess != targetNumber)
                {
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > targetNumber)
                    {
                        Console.WriteLine("Enter a smaller number.");
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("Enter a larger number.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You guessed the number: " + targetNumber);
                        break;
                    }

                    attempts--;
                    Console.WriteLine("Remaining attempts: " + attempts);
                }

                if (attempts == 0)
                {
                    Console.WriteLine("Sorry, you ran out of attempts. The correct number was: " + targetNumber);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
