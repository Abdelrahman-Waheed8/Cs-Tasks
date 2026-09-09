public class Question24
{
    public static void Run()
    {
        Console.Write("Enter Month number: ");
        int.TryParse(Console.ReadLine(), out int month);

        int numbersOfDaysInMonth = DateTime.DaysInMonth(2026 ,month); // 2026 akenaha base year
        Console.WriteLine($"Month {month} has {numbersOfDaysInMonth} days");
    }   
}