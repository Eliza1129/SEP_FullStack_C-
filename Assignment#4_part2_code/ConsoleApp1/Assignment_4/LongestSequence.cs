namespace Assignment_4;
using System.Linq;
public class LongestSequence
{
    public static int[] FindLongestSequence(int[] arr)
    {
        int maxLength = 1, currentLength = 1;
        int bestStart = 0, currentStart = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
                currentStart = i;
            }

            if (currentLength > maxLength) 
            {
                maxLength = currentLength;
                bestStart = currentStart;
            }
        }

        return arr.Skip(bestStart).Take(maxLength).ToArray(); 
    }
}