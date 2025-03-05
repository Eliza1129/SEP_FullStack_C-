namespace ConsoleApp3;

public class PrintPyramid
{
    public static void Print(int rows)
    {
        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j < rows - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < (2 * i - 1); k++)
            {
               Console.Write("*"); 
            }
            Console.WriteLine();
        }
    }
}