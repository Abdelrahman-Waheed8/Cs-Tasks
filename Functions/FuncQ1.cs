public class FuncQ1
{
    public static void ChangeByValue(int number)
    {
        number = 513;
    }

    public static void ChangeByReference(ref int number)
    {
        number = 80;
    }
    public static void Run()
    {
        int num = 1;
        ChangeByValue(num);
        Console.WriteLine($"By value: {num}");

        ChangeByReference(ref num);
        Console.WriteLine($"By reference: {num}");
    }
}