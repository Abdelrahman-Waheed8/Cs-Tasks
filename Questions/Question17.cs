public class Question17
{
    public static void Run()
    {
        Console.Write("Enter number: ");
        int.TryParse(Console.ReadLine(), out int number);
        
        if(number % 2 == 0) Console.WriteLine("Even");
        else Console.WriteLine("Odd");
    }
}