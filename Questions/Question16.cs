using System.Net.Mail;

public class Question16
{
    public static void Run()
    {
        int num1, num2, num3;
        Console.Write("Enter number 1: ");
        int.TryParse(Console.ReadLine(), out num1);
        Console.Write("Enter number 2: ");
        int.TryParse(Console.ReadLine(), out num2);
        Console.Write("Enter number 3: ");
        int.TryParse(Console.ReadLine(), out num3);
        
        int max = Math.Max(num1 , Math.Max(num2, num3));
        int min = Math.Min(num1 , Math.Min(num2, num3));
        Console.WriteLine($"Maximum number: {max}\nMinimum number: {min}");
    }
}