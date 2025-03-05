namespace Assignment_4;

public class Prime
{
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes.ToArray();
    }

    private static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}