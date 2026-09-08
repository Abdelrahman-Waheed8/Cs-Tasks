public class Question19
{
    public static void Run()
    {
        Console.Write("Enter number: ");
        int.TryParse(Console.ReadLine(), out int number);
        
        for(int i = 1; i <= number; i++)
        {
            Console.Write(i);
            if(i != number) Console.Write(", ");
        }
    }
}