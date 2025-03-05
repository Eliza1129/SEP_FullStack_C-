namespace Assignment_4;

public class ArrayCopy
{
    public static void CopyArray()
    {
        //create the new original array with 10 items
        int[] originalArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        
        // create a new Array with same length
        int[] copyArray = new int[originalArray.Length];
        
        // copy elements using a loop
        for (int i = 0; i < originalArray.Length; i++)
        {
            copyArray[i] = originalArray[i];
        }
        Console.WriteLine("Original array:" + string.Join(",", originalArray));
        Console.WriteLine("Copy array:" + string.Join(",", copyArray));
    }
}