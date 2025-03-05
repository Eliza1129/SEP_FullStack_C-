// See https://aka.ms/new-console-template for more information

// the original code will cause an infinite loop due to byte overflow. i starts at 0 and increments.
// once i reaches 255, adding 1 wraps it back to 0.
using System;
using ConsoleApp3;

class Program
{
    static void Main()
    {
        Console.WriteLine("Checking for Byte Overflow:");
        int max = 500;
        bool warned = false;
        for (byte i = 0; i < max; i++)
        {
            if (i == 0 && warned)
            {
                Console.WriteLine("Warning: Byte overflow! Stopping loop.");
                break;  
            }
            Console.WriteLine(i);
            warned = true;
        }

        Console.WriteLine();  

        // Print Pyramid
        Console.WriteLine("Printing Pyramid:");
        PrintPyramid.Print(5);  
        
        Console.WriteLine();  

        // Run Number Guessing Game
        Console.WriteLine("Starting Number Guessing Game:");
        NumberGuessingGame.Play(); 
        
        // Print Age
        DateTime birthDate = new DateTime(1997, 02, 11);
        
        AgeCalculator.CalculateAge(birthDate);
        
        // Greeting
        Greeting.GreetUser();
        
        //Counting up to 24
        CountingProgram.Counting();
    }
}
 