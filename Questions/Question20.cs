public class Question20
{
    public static void Run()
    {
        Console.Write("Enter number: ");
        int.TryParse(Console.ReadLine(), out int number);

        for(int i = 1 ; i<=12 ; i++)
        {
            Console.Write($"{number * i} ");
        }
    }
}