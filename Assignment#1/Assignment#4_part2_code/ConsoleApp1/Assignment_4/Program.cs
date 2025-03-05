// See https://aka.ms/new-console-template for more information

using System;
namespace Assignment_4;

class Program
{
    static void Main()
    {
        // 1.Copying an Array
        ArrayCopy.CopyArray();
        
        //2. item
        ListManager.ManageList();
        
        //3. prime number
        int start = 10, end = 50;
        int[] primes = Prime.FindPrimesInRange(start, end);

        Console.WriteLine($"Prime numbers between {start} and {end}:");
        Console.WriteLine(string.Join(", ", primes));
        
        //4. Rotated Array
        // Read input array
        Console.WriteLine("Enter space-separated integers:");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Read number of rotations
        Console.WriteLine("Enter number of rotations:");
        int k = int.Parse(Console.ReadLine());

        // Compute the rotated sum array
        int[] result = ArraySum.GetRotatedSum(arr, k);

        // Print the result
        Console.WriteLine("Rotated Sum Array:");
        Console.WriteLine(string.Join(" ", result));
        
        //5. finds the longest sequence of equal elements
        Console.WriteLine("Enter space-separated integers:");
        int[] arr1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        int[] result1 = LongestSequence.FindLongestSequence(arr1);

        // Print result
        Console.WriteLine("Longest sequence of equal elements:");
        Console.WriteLine(string.Join(" ", result1));
        
        // 6. Find the most frequent number
        Console.WriteLine("Enter space-separated integers:");
        int[] arr2 = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries) // Handle extra spaces
            .Select(int.Parse)
            .ToArray();

        // Find and print the most frequent number(s)
        MostFrequentNumber.FindMostFrequent(arr2);
    }
}
