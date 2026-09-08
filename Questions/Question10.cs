public class Question10
{
    public static void Run()
    {
        Console.WriteLine("Enter Day: ");
        int.TryParse(Console.ReadLine(), out int day);
        Console.WriteLine("Enter Month: ");
        int.TryParse(Console.ReadLine(), out int month);
        Console.WriteLine("Enter Year: ");
        int.TryParse(Console.ReadLine(), out int year);

        Console.WriteLine($"{day} , {month} , {year}");
        Console.WriteLine($"{day} / {month} / {year}");
        Console.WriteLine($"{day} - {month} - {year}");

    }
}