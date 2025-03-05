// See https://aka.ms/new-console-template for more information

namespace Practice_Strings;

class Program
{
    static void Main()
    {
        /*// 1. ReverseString
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        Console.WriteLine("Reversed using Method 1:");
        Reverse.ReverseString1(input);
        
        Console.WriteLine("Reversed using Method 2:");
        Reverse.ReverseString2(input);*/
        
        /*//2. ReverseWords
        Console.WriteLine("Enter a sentence:");
        string input1 = Console.ReadLine();

        string reversed = ReverseWords.ReverseSentenceWords(input1);

        Console.WriteLine("\nReversed Sentence:");
        Console.WriteLine(reversed);*/
        
        /*// 3.Palindrome
        Console.WriteLine("Enter text:");
        string input3 = Console.ReadLine();

        Console.WriteLine("\nPalindromes found:");
        PalindromeChecker.ExtractAndPrintPalindromes(input3);*/
        
        //4.URLParser
        Console.WriteLine("Enter a URL:");
        string url = Console.ReadLine();

        Console.WriteLine("\nParsed URL:");
        URLParser.ParseURL(url);
        
    }
}
