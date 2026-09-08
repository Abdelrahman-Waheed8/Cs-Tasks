public class Question21
{
    public static void Run()
    {
        Console.Write("Enter number: ");
        int.TryParse(Console.ReadLine(), out int number);

        for(int i = 0; i <= number ; i++)
        {
            if(i % 2 == 0) Console.Write($"{i} ");
        }
    }
}