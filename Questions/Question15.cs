public class Question15
{
    public static void Run()
    {
        Console.WriteLine("Enter number: ");
        int.TryParse(Console.ReadLine(), out int number);

        if(number >= 0) Console.WriteLine("Positive");
        else Console.WriteLine("Negative");
    }
}