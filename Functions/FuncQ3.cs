using System.Runtime.InteropServices;

public class FuncQ3
{
    public static void Calculate(int num1, int num2, out int sum, out int difference)
    {
        sum = num1 + num2;
        difference = num1 - num2;
    }
    public static void Run()
    {
        Console.Write("Enter number 1: ");
        int.TryParse(Console.ReadLine(), out int number1);
        Console.Write("Enter number 2: ");
        int.TryParse(Console.ReadLine(), out int number2);
        Calculate(number1, number2, out int sum, out int difference);
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
    }
}