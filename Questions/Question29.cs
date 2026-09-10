public class Question29
{
    public static void Run()
    {
        Console.Write("Enter a number to convert to Binary: ");
        int.TryParse(Console.ReadLine(), out int number);
        string binary = Convert.ToString(number, 2);
        Console.WriteLine($"Converted to binary: {binary}");
    }
}