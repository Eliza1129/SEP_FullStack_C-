// See https://aka.ms/new-console-template for more information

using System;
namespace Generic_List;

    class Program
    {
        static void Main()
        {
            MyList<int> intList = new MyList<int>();

            // Add elements
            intList.Add(5);
            intList.Add(10);
            intList.Add(15);
            Console.WriteLine("List after adding elements:");
            intList.PrintAll();

            // Remove an element
            Console.WriteLine("Removed: " + intList.Remove(1));
            intList.PrintAll();

            // Check if an element exists
            Console.WriteLine("Contains 10? " + intList.Contains(10));
            Console.WriteLine("Contains 50? " + intList.Contains(50));

            // Insert at a specific position
            intList.InsertAt(25, 1);
            Console.WriteLine("List after inserting 25 at index 1:");
            intList.PrintAll();

            // Delete an element at index
            intList.DeleteAt(0);
            Console.WriteLine("List after deleting element at index 0:");
            intList.PrintAll();

            // Find an element at a specific index
            Console.WriteLine("Element at index 1: " + intList.Find(1));

            // Clear the list
            intList.Clear();
            Console.WriteLine("List after clearing:");
            intList.PrintAll();
        }
    }

