public class Question09
{
    public static void Run()
    {
        Console.WriteLine("Enter Weight in kg: ");
        double.TryParse(Console.ReadLine(), out double weight);
        Console.WriteLine("Enter Height in meters: ");
        double.TryParse(Console.ReadLine(), out double height);

        Console.WriteLine($"BMI: {weight / (height * height)}");
    }
}