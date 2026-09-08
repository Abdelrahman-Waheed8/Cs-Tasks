public class Question01
{
    public static void Run()
    {
        Console.WriteLine("Enter number: ");
        int.TryParse(Console.ReadLine(), out int number);
        Console.WriteLine(number);
    }
}