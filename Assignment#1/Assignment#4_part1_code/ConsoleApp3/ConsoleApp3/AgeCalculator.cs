namespace ConsoleApp3;

public class AgeCalculator
{
    public static void CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Now;
        
        int days = (today - birthDate).Days;
        Console.WriteLine($"You are {days} days old");
        
        int daysToNextAnniversary = 10000 - (days % 10000);
        DateTime nextAnniversaryDate = today.AddDays(daysToNextAnniversary);
        Console.WriteLine($"Your next 10,000-day anniversary will be on: {nextAnniversaryDate:yyyy-MM-dd}");
    }
}