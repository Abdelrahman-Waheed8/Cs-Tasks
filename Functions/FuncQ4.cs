public class FuncQ4
{
    public static int CalculateSum(int num)
    {
        int sum =0;
        int remainder;
        while(num > 0)
        {
            remainder = num%10;
            sum += remainder;
            num /= 10;
        }
        return sum;
    }
    public static void Run()
    {
        Console.Write("Enter a number to add its digits: ");
        int.TryParse(Console.ReadLine(), out int number);
        Console.WriteLine($"Added digits {CalculateSum(number)}");
    }
}