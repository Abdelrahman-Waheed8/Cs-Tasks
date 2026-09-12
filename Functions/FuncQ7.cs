public class FuncQ7
{
    public static int Factorial(int number)
    {
        if (number < 0) return -1;
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
    public static void Run()
    {
        Console.Write("Enter number to find factorial for: ");
        int.TryParse(Console.ReadLine(), out int num);
        Console.WriteLine($"Factorial for {num}: {Factorial(num)}");
    }
}