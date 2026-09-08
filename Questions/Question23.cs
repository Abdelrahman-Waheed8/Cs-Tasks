public class Question23
{
    public static void Run()
    {
        Console.Write("Enter five subjects marks seperated by spaces: ");
        string FiveSubjects = Console.ReadLine() ?? "";

        int.TryParse(FiveSubjects.Split(' ')[0], out int sub1);
        int.TryParse(FiveSubjects.Split(' ')[1], out int sub2);
        int.TryParse(FiveSubjects.Split(' ')[2], out int sub3);
        int.TryParse(FiveSubjects.Split(' ')[3], out int sub4);
        int.TryParse(FiveSubjects.Split(' ')[4], out int sub5);

        int total = sub1 + sub2 + sub3 + sub4 + sub5;
        int average = total / 5;
        double percentage = ((double)total / 500) * 100;

        Console.WriteLine($"Total marks: {total}");
        Console.WriteLine($"Average : {average}");
        Console.WriteLine($"Percentage: {percentage}%");
    }
}