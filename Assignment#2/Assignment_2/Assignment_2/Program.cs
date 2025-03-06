// See https://aka.ms/new-console-template for more information

using System;

namespace Assignment_2;
class Program
{
    static void Main()
    {
        int[] numbers = GenerateNumbers(10); 
        Reverse(numbers); 
        PrintNumbers(numbers); 
    }

    // generate an array with sequential numbers
    static int[] GenerateNumbers(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    // reverse the array
    static void Reverse(int[] array)
    {
        /*int left = 0;
        int right = array.Length - 1;
        
        while (left < right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            left++;  
            right--; 
        }*/
        Array.Reverse(array);
    }

    // print the array
    static void PrintNumbers(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine(); 
    }
}
