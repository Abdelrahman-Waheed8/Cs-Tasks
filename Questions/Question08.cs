public class Question08
{
    public static void Run()
    {
        Console.WriteLine("Enter Principal Amount: ");
        double.TryParse(Console.ReadLine(), out double principalAmount);
        Console.WriteLine("Enter Rate of interest: ");
        double.TryParse(Console.ReadLine(), out double rateOfInterest);
        Console.WriteLine("Enter time: ");
        double.TryParse(Console.ReadLine(), out double time);

        Console.WriteLine($"simple interest: {principalAmount * rateOfInterest * time / 100}");
    }
}