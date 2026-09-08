public class Question04
{
    public static void Run()
    {
        string name = "Abdelrahman Waheed";
        string fName = name.Substring(0, 11);
        string lName = name.Substring(12);
        Console.WriteLine($"First name: {fName}");
        Console.WriteLine($"Last name: {lName}");
    }
}