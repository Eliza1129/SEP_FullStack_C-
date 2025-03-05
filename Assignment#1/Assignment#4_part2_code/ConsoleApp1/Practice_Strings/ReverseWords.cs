namespace Practice_Strings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
public class ReverseWords
{
    public static string ReverseSentenceWords(string input)
    {
        string pattern = @"([.,;=()&\[\]""'\/!? ])";
        List<string> words = new List<string>();
        List<string> separators = new List<string>();
        
        string[] parts = Regex.Split(input, pattern);

        foreach (string part in parts)
        {
            if (!string.IsNullOrEmpty(part))
            {
                if (Regex.IsMatch(part, pattern)) 
                    separators.Add(part); 
                else 
                    words.Add(part);
            }
        }
        words.Reverse();
        
        StringBuilder result = new StringBuilder();
        int wordIndex = 0, separatorIndex = 0;

        foreach (string part in parts)
        {
            if (!string.IsNullOrEmpty(part))
            {
                if (Regex.IsMatch(part, pattern))
                    result.Append(separators[separatorIndex++]); 
                else
                    result.Append(words[wordIndex++]);
            }
        }

        return result.ToString();
    }

}