// See https://aka.ms/new-console-template for more information
using System;
namespace Assignment_3;

class Program
{
    static void Main()
    {
        Mystack<int> intStack = new Mystack<int>();
        intStack.Push(10);
        intStack.Push(20);
        
        Console.WriteLine(intStack.Count()); 
        Console.WriteLine(intStack.Pop());   
        Console.WriteLine(intStack.Count());
    }
}

