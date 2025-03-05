namespace Practice_Strings;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class PalindromeChecker
{
    public static void ExtractAndPrintPalindromes(string input)
    {
        string[] words = Regex.Split(input, @"\W+"); 

        HashSet<string> palindromes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word) && IsPalindrome(word))
            {
                palindromes.Add(word); 
            }
        }
        
        var sortedPalindromes = palindromes.OrderBy(p => p, StringComparer.OrdinalIgnoreCase);
        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }

    private static bool IsPalindrome(string word)
    {
        string reversed = new string(word.Reverse().ToArray());
        return word.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}
