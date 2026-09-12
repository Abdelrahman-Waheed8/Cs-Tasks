public class FuncQ5
{
    public static bool IsPrime(int number)
    {
        if (number < 2)
        return false;

    for (int i = 2; i <= number / i; i++)
        {
            if (number % i == 0)
                return false;
        }

    return true;
    }
    public static void Run()
    {
        Console.Write($"Enter number: ");
        int.TryParse(Console.ReadLine(), out int num);
        if(IsPrime(num)) Console.WriteLine("Prime");
        else Console.WriteLine("Not Prime");
    }
}