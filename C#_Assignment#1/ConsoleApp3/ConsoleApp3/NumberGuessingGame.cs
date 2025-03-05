namespace ConsoleApp3;

public class NumberGuessingGame
{
    public static void Play()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Guess a number between 1 and 3");

        try
        {
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Invalid number.Please enter a number between 1 and 3.");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Too High! Try again.");
            }
            else
            {
                Console.WriteLine("Correct! You guessed the number.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.Please enter a number between 1 and 3.");
        }
    }
}