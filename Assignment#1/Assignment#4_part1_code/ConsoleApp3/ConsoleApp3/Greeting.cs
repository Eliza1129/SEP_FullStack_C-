namespace ConsoleApp3;

public class Greeting
{
    public static void GreetUser()
    {
        DateTime now = DateTime.Now;
        int hour = now.Hour;
        
        Console.WriteLine($"Current time: {now:HH:mm}");

        if (hour >= 5 && hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("Good Afternoon");
        }

        if (hour >= 18 && hour < 24)
        {
            Console.WriteLine("Good Evening");
        }

        if (hour >= 24 || hour < 5)
        {
            Console.WriteLine("Good Night");
        }
    }
}