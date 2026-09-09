public class Question27
{
    public static void Run()
    {
        Console.Write("Enter Number to reverse: ");
        int.TryParse(Console.ReadLine(), out int number);
        int remainder ;
        int reversed = 0;
        while (number > 0)
        {
            remainder = number % 10;    // rem = 5
            reversed = (reversed *10) + remainder;   // reversed = 50
            number /= 10;               // number = 1
        }
        Console.WriteLine($"Reversed: {reversed}");
    }
}