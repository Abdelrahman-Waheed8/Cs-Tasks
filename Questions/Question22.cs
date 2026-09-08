public class Question22
{
    public static void Run()
    {
        int result = 1;
        Console.Write("Enter number: ");
        int.TryParse(Console.ReadLine(), out int number);
        Console.Write("Enter power: ");
        int.TryParse(Console.ReadLine(), out int power);

        for(int i = 0; i < power; i++)
        {
            result *= number;
        }
        Console.WriteLine(result);
    }
}