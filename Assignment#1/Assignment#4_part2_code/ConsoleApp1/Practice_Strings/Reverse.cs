namespace Practice_Strings;

public class Reverse
{
    public static void ReverseString1(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }

    public static void ReverseString2(string input)
    {
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }
}