public class Question14
{
    public static void Run()
    {
        Console.WriteLine("Enter number: ");
        int.TryParse(Console.ReadLine(), out int number);

        if(number % 3 == 0 && number % 4 == 0) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}