namespace Assignment_4;

using System;
using System.Collections.Generic;
using System.Linq;

public class MostFrequentNumber
{
    public static void FindMostFrequent(int[] arr)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        int maxFrequency = 0;
        List<int> mostFrequentNumbers = new List<int>();

        // Count occurrences of each number
        foreach (int num in arr)
        {
            if (!frequencyMap.ContainsKey(num))
                frequencyMap[num] = 0;

            frequencyMap[num]++;

            // Update max frequency
            if (frequencyMap[num] > maxFrequency)
            {
                maxFrequency = frequencyMap[num];
                mostFrequentNumbers = new List<int> { num }; // Reset to new most frequent number
            }
            else if (frequencyMap[num] == maxFrequency)
            {
                mostFrequentNumbers.Add(num); // Add number with the same max frequency
            }
        }

        // Find the leftmost number from input sequence
        int leftmost = arr.First(num => mostFrequentNumbers.Contains(num));

        // Print result
        if (mostFrequentNumbers.Count == 1)
        {
            Console.WriteLine($"The number {leftmost} is the most frequent (occurs {maxFrequency} times)");
        }
        else
        {
            Console.WriteLine($"The numbers {string.Join(", ", mostFrequentNumbers)} have the same maximal " +
                              $"frequency (each occurs {maxFrequency} times). The leftmost of them is {leftmost}.");
        }
    }
}
