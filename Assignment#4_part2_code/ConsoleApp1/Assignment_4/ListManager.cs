namespace Assignment_4;
using System;
using System.Collections.Generic;

public class ListManager
{
    public static void ManageList()
    {
        List<string> itemlist = new List<string>();

        while (true)
        {
            Console.WriteLine("\nPlease enter:(+ item, - item, or -- to clear, type 'exit' to quit): ");
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (input.ToLower() == "--")
            {
                itemlist.Clear();
                Console.WriteLine("List cleared!");
            }
            else if (input.StartsWith("+ "))
            {
                string item = input.Substring(2).Trim();
                if (!string.IsNullOrEmpty(item))
                {
                    itemlist.Add(item);
                    Console.WriteLine($"Added: {item}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else if (input.StartsWith("- "))
            {
                string item = input.Substring(2).Trim();
                if (itemlist.Remove(item))
                {
                    Console.WriteLine($"Removed: {item}");
                }
                else
                {
                    Console.WriteLine($"Item '{item}' not found in the list.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Use + item, - item, or -- to clear.");
            }
            // Show current list contents
            Console.WriteLine("\nCurrent List:");
            if (itemlist.Count > 0)
            {
                foreach (var item in itemlist)
                {
                    Console.WriteLine("- " + item);
                }
            }
            else
            {
                Console.WriteLine("(List is empty)");
            }
        }
    }
}