namespace Assignment_4;

public class ArraySum
{
    public static int[] RotateRight(int[] arr)
    {
        int n = arr.Length;
        int[] rotated = new int[n];

        for (int i = 0; i < n; i++)
        {
            rotated[(i + 1) % n] = arr[i];
        }

        return rotated;
    }
    public static int[] GetRotatedSum(int[] arr, int k)
    {
        int n = arr.Length;
        int[] sumArray = new int[n];
        int[] tempArray = arr.ToArray(); 

        for (int r = 0; r < k; r++)
        {
            tempArray = RotateRight(tempArray); 

            for (int i = 0; i < n; i++)
            {
                sumArray[i] += tempArray[i]; 
            }
        }

        return sumArray;
    }
}