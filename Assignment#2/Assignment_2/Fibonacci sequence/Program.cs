// See https://aka.ms/new-console-template for more information

using System;
namespace Fibonacci_sequence;

class Program
{
    static void Main()
    {
        Console.WriteLine("First 10 Fibonacci Numbers:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(Fibonacci(i) + " "); // Print first 10 Fibonacci numbers
        }
        Console.WriteLine(); 

        // Allow user to input a number and get the corresponding Fibonacci number
        Console.WriteLine("Enter a number to get the Fibonacci sequence value:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Fibonacci({num}) = {Fibonacci(num)}");
    }

    // Recursive Fibonacci method
    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
            return 1; // Base case: First and second Fibonacci numbers are always 1

        return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive case
    }
}

